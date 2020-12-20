
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using OpenBveApi.Math;
using OpenBveApi.Colors;
using System.Globalization;
using System.Collections;
using System.Reflection;

namespace CsvConvert {
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form {

        private Color24? TransparentColor = null;

		public MainForm() {
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			foreach (var control in tlpTransform.Controls) {
				var numericUpDown = control as NumericUpDown;
				if (numericUpDown != null) {
					numericUpDown.Minimum = -10000;
					numericUpDown.Maximum = 10000;
					numericUpDown.Value = numericUpDown.Name.Contains("S") ? 1 : 0;
				}
			}
			this.Font = SystemFonts.CaptionFont;
			var newHeight = groupBoxTransform.Location.Y + groupBoxTransform.Height + 50;
			this.MinimumSize = new Size(newHeight * 4 / 3, newHeight);
            this.Size = new Size(newHeight * 4 / 3, newHeight);
            cbFace2Type.SelectedItem = cbFace2Type.Items[0];
            cbLanguage.DataSource = new [] {
                new { Key = "en", Value = "English" },
                new { Key = "zh_CHS", Value = "简体中文" },
                new { Key = "zh_CHT", Value = "繁體中文" }
            };
            if (Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName == "zh") {
                cbLanguage.SelectedItem = cbLanguage.Items[1];
            } else {
                cbLanguage.SelectedItem = cbLanguage.Items[0];
            }

            foreach (DictionaryEntry entry in Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true)) {
                if (!entry.Key.ToString().StartsWith("lang_", StringComparison.Ordinal)) continue;
                languages.Add(
                    entry.Key.ToString().Replace("lang_", ""), 
                    entry.Value.ToString().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                        .Where(s => !string.IsNullOrEmpty(s.Trim()))
                        .ToDictionary(l => l.Split(new[] { ',' }, 2)[0].Trim(), l => l.Split(new[] { ',' }, 2)[1]));
            }
            ApplyLanguage();

        }

        private Dictionary<string, Dictionary<string, string>> languages = new Dictionary<string, Dictionary<string, string>>();

        private string Translate(string key, object param = null) {
            if (param == null) {
                return languages[cbLanguage.SelectedValue as string][key];
            } else {
                return string.Format(languages[cbLanguage.SelectedValue as string][key], param);
            }
        }

        private void ApplyLanguage(Control ctrl = null) {
            if (ctrl == null) ctrl = this;
            if (languages[cbLanguage.SelectedValue as string].ContainsKey(ctrl.Name)) {
                ctrl.Text = languages[cbLanguage.SelectedValue as string][ctrl.Name];
            }
            foreach (var child in ctrl.Controls) {
                ApplyLanguage(child as Control);
            }
            if (ctrl == this) {
                updateSetTransparentBtn();
                cbFace2Type.Items[0] = Translate("cbFace2None");
                cbFace2Type.Items[1] = Translate("cbFace2Command");
                cbFace2Type.Items[2] = Translate("cbFace2Double");
                var newHeight = groupBoxTransform.Location.Y + groupBoxTransform.Height + 50;
                this.MinimumSize = new Size(newHeight * 4 / 3, newHeight);
                this.Text += " " + Assembly.GetExecutingAssembly().GetName().Version;
                this.tbLog.Text += Environment.NewLine;
            }
        }
		
		internal void SummonWorkerThread(string[] files) {
            var option = new ConvertUtil.ConvertOption() {
                Translation = new Vector3((double)nudTX.Value, (double)nudTY.Value, (double)nudTZ.Value),
                Rotation = new Vector3((double)nudRX.Value, (double)nudRY.Value, (double)nudRZ.Value),
                Scale = new Vector3((double)nudSX.Value, (double)nudSY.Value, (double)nudSZ.Value),
                Mirror = new ConvertUtil.Bool3(cbMirrorX.Checked, cbMirrorY.Checked, cbMirrorZ.Checked),
                Face2Method = (ConvertUtil.Face2Method)cbFace2Type.SelectedIndex,
                OutputNormals = cbOutputNormals.Checked,
                RoundV = (int)nudRoundV.Value, RoundVN = (int)nudRoundV.Value, RoundVT = (int)nudRoundUV.Value,
                TransparentColor = this.TransparentColor,
                UseLocalEncoding = cbLocalCP.Checked
            };
            var workerThread = new Thread(
                () => ConvertUtil.ProcessFile(files, rbCsvModel.Checked ? ".csv" : ".hmmo", option,
                    (m, p) => Invoke((Action<ConvertUtil.Message, object>)((msg, param) => {
                        tbLog.AppendText(Translate(m.ToString(), p) + Environment.NewLine);
                        btnSelectFile.Enabled |= msg == ConvertUtil.Message.SequenceDone;
                    }), m, p)
                )
            );
            btnSelectFile.Enabled = false;
			workerThread.Start();
		}

        private static readonly string[] SupportedFormats = { ".obj", ".x", ".csv", ".b3d" };

        public void btnSelectFileClick(object sender, EventArgs e) {
			var ofd = new OpenFileDialog() {
				Filter = "All|*.obj,*.x,*.csv,*.b3d|Wavefront (*.obj)|*.obj|DirectX (*.x)|*.x|BVE (*.csv,*.b3d)|*.csv;*.b3d",
				Multiselect = true
			};
			if (ofd.ShowDialog() == DialogResult.OK) {
				SummonWorkerThread(ofd.FileNames);
			}
		}
		
		public void tbLogDragEnter(object sender, DragEventArgs e) {
            if (btnSelectFile.Enabled && e.Data.GetDataPresent(DataFormats.FileDrop) &&
                ((string[])e.Data.GetData(DataFormats.FileDrop))
                .Any(f => SupportedFormats.Any(x => f.EndsWith(x, StringComparison.OrdinalIgnoreCase)))) {
                e.Effect = DragDropEffects.Copy;
            }
		}
		
		public void tbLogDragDrop(object sender, DragEventArgs e) {
			var files = ((string[])e.Data.GetData(DataFormats.FileDrop))
				.Where(f => SupportedFormats.Any(x => f.EndsWith(x, StringComparison.OrdinalIgnoreCase))).ToArray();
			SummonWorkerThread(files);
		}
		
		void linkLabelCredit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			try {
				System.Diagnostics.Process.Start("https://www.zbx1425.cn");
			} catch { }
		}

        private void rbCsvModel_CheckedChanged(object sender, EventArgs e) {
            if (rbCsvModel.Checked) {
                cbOutputNormals.Enabled = true;
                nudRoundV.Enabled = true;
                nudRoundUV.Enabled = true;
            } else {
                cbOutputNormals.Enabled = false;
                cbOutputNormals.Checked = false;
                nudRoundV.Enabled = false;
                nudRoundUV.Enabled = false;
            }
        }

        private void updateSetTransparentBtn() {
            if (TransparentColor.HasValue) {
                btnSetTransparent.Text = string.Format(Translate("btnTransparentSelected"), 
                    TransparentColor?.R, TransparentColor?.G, TransparentColor?.B);
                btnSetTransparent.BackColor = Color.FromArgb((int)TransparentColor?.R, (int)TransparentColor?.G, (int)TransparentColor?.B);
                int bgDelta = Convert.ToInt32((btnSetTransparent.BackColor.R * 0.299) + (btnSetTransparent.BackColor.G * 0.587) +
                                  (btnSetTransparent.BackColor.B * 0.114));
                btnSetTransparent.ForeColor = (255 - bgDelta < 105) ? Color.Black : Color.White;
            } else {
                btnSetTransparent.Text = Translate("btnTransparentNone");
                btnSetTransparent.BackColor = tlpMisc.BackColor;
                btnSetTransparent.ForeColor = Color.Black;
            }
        }

        private void btnSetTransparent_Click(object sender, EventArgs e) {
            var cd = new ColorDialog() {
                Color = TransparentColor.HasValue
                    ? Color.FromArgb((int)TransparentColor?.R, (int)TransparentColor?.G, (int)TransparentColor?.B)
                    : Color.Blue,
                FullOpen = true
            };
            if (cd.ShowDialog() == DialogResult.OK) {
                TransparentColor = new Color24(cd.Color.R, cd.Color.G, cd.Color.B);
            } else {
                TransparentColor = null;
            }
            updateSetTransparentBtn();
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e) {
            this.SuspendLayout();
            if (languages.Count > 0) ApplyLanguage();
            this.ResumeLayout();
        }

        private void tbLog_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.D && e.Control) tbLog.Text = Translate("tbLog") + Environment.NewLine;
        }
    }
}
