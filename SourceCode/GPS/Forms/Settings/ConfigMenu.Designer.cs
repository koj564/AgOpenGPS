﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormConfig
    {
        private void HideSubMenu()
        {
            panelVehicleSubMenu.Visible = false;
            panelToolSubMenu.Visible = false;
            panelDataSourcesSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            tab1.SelectedTab = tabSummary;
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region Top Menu Btns

        private void btnHome_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabSummary;
            HideSubMenu();
            UpdateSummary();
        }

        private void UpdateSummary()
        {
            lblSumWheelbase.Text = Properties.Vehicle.Default.setVehicle_wheelbase.ToString();
            lblSumToolWidth.Text = mf.tool.toolWidth.ToString();
            lblSumNumSections.Text = mf.tool.numOfSections.ToString();

            //lblSumCurrentVehicle.Text = Properties.Settings.Default...........ToString();
            //lblSumCurrentTool.Text = Properties.Tool.Default.toolSettings.toolFileName.ToString();
            //lblSumCurrentDataSource.Text = Properties.DataSource.Default.dataSourceSettings.dataSourceFileName.ToString();
            //lblSumFixType.Text = Properties.DataSource.Default.dataSourceSettings.fixFrom.ToString();
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelToolSubMenu);
            tab1.SelectedTab = tabSummary;
            UpdateVehicleListView();
            UpdateSummary();

        }

        private void btnDataSources_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelDataSourcesSubMenu);
            tab1.SelectedTab = tabSummary;
            //lblCurrentData.Text = gStr.gsCurrent + mf.dataSourceFileName;
            UpdateVehicleListView();
            UpdateSummary();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelVehicleSubMenu);
            tab1.SelectedTab = tabSummary;

            lblCurrentVehicle.Text = gStr.gsCurrent + mf.vehicleFileName;
            UpdateVehicleListView();
            UpdateSummary();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Vehicle Sub Menu Btns
        private void btnSubVehicleType_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabVConfig;
        }

        private void btnSubDimensions_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabVDimensions;
        }

        private void btnSubAntenna_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabVAntenna;
        }

        private void btnSubGuidance_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabVGuidance;
        }

        #endregion Region

        #region Tool Sub Menu
        private void btnSubToolType_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabTConfig;
        }

        private void btnSubHitch_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabTHitch;
        }

        private void btnSubSections_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabTSections;
        }

        private void btnSubSwitches_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabTSwitches;
        }

        private void btnSubToolSettings_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabTSettings;
        }
        #endregion

        #region SubMenu Data Sources
        private void btnSubRoll_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabDRoll;
        }

        private void btnSubHeading_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabDHeading;

        }

        private void btnSubFix_Click(object sender, EventArgs e)
        {
            tab1.SelectedTab = tabDFix;
        }

        #endregion        

    }
}
