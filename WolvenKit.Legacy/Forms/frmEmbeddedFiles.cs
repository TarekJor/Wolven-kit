﻿using System.IO;
using BrightIdeasSoftware;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W;
using WolvenKit.Services;
using System.Linq;
using WolvenKit.Model;
using System.Windows.Controls;
using WolvenKit.ViewModels;
using System;
using WolvenKit.Common.Model;

namespace WolvenKit
{
    public partial class frmEmbeddedFiles : DockContent, IThemedContent
    {
        private CR2WFile file;

        public event EventHandler<RequestEmbeddedFileOpenArgs> RequestFileOpen;

        public frmEmbeddedFiles()
        {
            InitializeComponent();
            ApplyCustomTheme();
            UpdateList();
        }

        public CR2WFile File
        {
            get { return file; }
            set
            {
                file = value;
                UpdateList();
            }
        }

        private void UpdateList()
        {
            if (File == null)
                return;

            listView.Objects = File.Embedded;
        }

        private void listView_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.Column == null || e.Item == null)
                return;

            if (e.ClickCount == 2)
            {
                if (e.Model is CR2WEmbeddedWrapper embedded)
                {
                    RequestFileOpen?.Invoke(this, new RequestEmbeddedFileOpenArgs(embedded));
                }
                
            }
        }

        

        public void ApplyCustomTheme()
        {
            this.listView.BackColor = UIController.GetBackColor();
            this.listView.AlternateRowBackColor = UIController.GetPalette().OverflowButtonHovered.Background;

            this.listView.ForeColor = UIController.GetForeColor();

            this.listView.HeaderFormatStyle = UIController.GetHeaderFormatStyle();
            listView.UnfocusedSelectedBackColor = UIController.GetPalette().CommandBarToolbarButtonPressed.Background;
        }
    }
}