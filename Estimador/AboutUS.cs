using Estimador.CustomControls;
using Estimador.Entities;
using Estimador.LanguagesSupport;
using Estimador.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using G = System.Globalization;
namespace Estimador
{
    public partial class AboutUS : Form
    {
        LanguageSupportManager languageSupportManager = new LanguageSupportManager();

        public AboutUS()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutUS_Load_1(object sender, EventArgs e)
        {
            LoadLicense();

            titleLabel.Text = languageSupportManager.GetStringValue("AboutUS_Title_Descriptor");
            nameLabel.Text = languageSupportManager.GetStringValue("AboutUS_Name_Descriptor");
            CompanyLabel.Text = languageSupportManager.GetStringValue("AboutUS_Company_Descriptor");
            VersionLabel.Text = languageSupportManager.GetStringValue("AboutUS_Version_Descriptor");

            string version = System.Windows.Forms.Application.ProductVersion;
            VersionData.Text = version;
        }

        private void LoadLicense()
        {
            using (StreamReader license = new StreamReader("license.txt"))
            {
                licenseAgreementText.Text = license.ReadToEnd();
            }
        }
    }
}
