﻿using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using WolvenKit;
using WolvenKit.Common.Services;

namespace WolvenKit
{
    public partial class frmPackSettings : Form
    {
        public PackSettings PackSettings => new PackSettings()
        {
            PackBundles = (modBDL.Checked, dlcBDL.Checked),
            GenMetadata = (modMD.Checked, dlcMD.Checked),
            GenTexCache = (modTEX.Checked, dlcTEX.Checked),
            GenCollCache = (modCOL.Checked, dlcCOL.Checked),
            Scripts = (modSCR.Checked, dlcSCR.Checked),
            Sound = (modSND.Checked, dlcSND.Checked),
            Strings = (modSTR.Checked, dlcSTR.Checked),
            InstallProject = checkBoxInstallMod.Checked
        };

        public frmPackSettings()
        {
            var activemod = MainController.Get().ActiveMod;

            InitializeComponent();

            checkBoxInstallMod.Checked = !MainController.Get().Configuration.IsAutoInstallModsDisabled;

            // Bundles + Metadata
            if (Directory.GetFiles(activemod.ModCookedDirectory, "*.*", SearchOption.AllDirectories).Any())
            {
                modBDL.Checked = true;
                modMD.Checked = true;
            }
            if (Directory.GetFiles(activemod.ModUncookedDirectory, "*.*", SearchOption.AllDirectories).Any())
            {
                modBDL.Checked = true;
                modMD.Checked = true;
            }

            if (Directory.GetFiles(activemod.DlcCookedDirectory, "*.*", SearchOption.AllDirectories).Any())
            {
                dlcBDL.Checked = true;
                dlcMD.Checked = true;
            }
            if (Directory.GetFiles(activemod.DlcUncookedDirectory, "*.*", SearchOption.AllDirectories).Any())
            {
                dlcBDL.Checked = true;
                dlcMD.Checked = true;
            }

            // Textures
            var texallowedExtensions = new[] { ".xbm", ".dds", ".png", ".jpg" };
            if (Directory
                .GetFiles(activemod.ModUncookedDirectory, "*", SearchOption.AllDirectories)
                .Any(file => texallowedExtensions.Any(file.ToLower().EndsWith)))
                modTEX.Checked = true;
            if (Directory
                .GetFiles(activemod.DlcUncookedDirectory, "*", SearchOption.AllDirectories)
                .Any(file => texallowedExtensions.Any(file.ToLower().EndsWith)))
                dlcTEX.Checked = true;

            // Sound
            var allowedExtensions = new[] { ".wem", ".bnk" };
            if (Directory
                .GetFiles(activemod.ModDirectory, "*", SearchOption.AllDirectories)
                .Any(file => allowedExtensions.Any(file.ToLower().EndsWith)))
                modSND.Checked = true;
            if (Directory
                .GetFiles(activemod.DlcDirectory, "*", SearchOption.AllDirectories)
                .Any(file => allowedExtensions.Any(file.ToLower().EndsWith)))
                dlcSND.Checked = true;

            // Scripts  
            if (Directory.GetFiles(activemod.ModDirectory, "*.ws", SearchOption.AllDirectories).Any())
                modSCR.Checked = true;
            if (Directory.GetFiles(activemod.DlcDirectory, "*.ws", SearchOption.AllDirectories).Any())
                dlcSCR.Checked = true;

            // Strings
            if (Directory.Exists(MainController.Get().ActiveMod.ProjectDirectory + "\\strings")
                && Directory.GetFiles(MainController.Get().ActiveMod.ProjectDirectory + "\\strings")
                .Any(x => x.EndsWith(".w3strings")))
                modSTR.Checked = true;

            // Collision
            //TODO: disable for now
            //if (Directory.GetFiles(activemod.ModUncookedDirectory, "*", SearchOption.AllDirectories).Any())
            //    modCOL.Checked = true;
            //if (Directory.GetFiles(activemod.DlcUncookedDirectory, "*", SearchOption.AllDirectories).Any())
            //    dlcCOL.Checked = true;

            this.Icon = UIController.GetThemedWkitIcon();

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MainController.Get().Configuration.IsAutoInstallModsDisabled = !checkBoxInstallMod.Checked;

            if (modBDL.Checked | modMD.Checked | dlcBDL.Checked | dlcMD.Checked 
            | modTEX.Checked | dlcTEX.Checked | modSND.Checked | dlcSND.Checked
            | modSCR.Checked | dlcSCR.Checked | modSTR.Checked | modCOL.Checked | dlcCOL.Checked)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MainController.Get().Configuration.IsAutoInstallModsDisabled = !checkBoxInstallMod.Checked;

            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
