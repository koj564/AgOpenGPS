﻿//Please, if you use this give me some credit
//Copyright BrianTee, copy right out of it.

using System;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormGPSData : Form
    {
        private readonly FormGPS mf;

        public FormGPSData(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            lblZone.Text = mf.Zone;

                lblEastingField.Text = Math.Round(mf.pn.fix.easting, 1).ToString();
                lblNorthingField.Text = Math.Round(mf.pn.fix.northing, 1).ToString();

                lblEasting.Text = ((int)mf.pn.actualEasting).ToString();
                lblNorthing.Text = ((int)mf.pn.actualNorthing).ToString();

            lblLatitude.Text = mf.Latitude;
            lblLongitude.Text = mf.Longitude;

            //other sat and GPS info
            lblFixQuality.Text = mf.FixQuality;
            lblSatsTracked.Text = mf.SatsTracked;
            lblStatus.Text = mf.Status;
            lblHDOP.Text = mf.HDOP;
            tboxNMEASerial.Lines = mf.recvSentenceSettings;
            lblSpeed.Text = mf.pn.speed.ToString();

            lblUturnByte.Text = Convert.ToString(mf.mc.machineData[mf.mc.mdUTurn], 2).PadLeft(6, '0');

            lblRoll.Text = mf.RollInDegrees;
            lblYawHeading.Text = mf.GyroInDegrees;
            lblGPSHeading.Text = mf.GPSHeading;
            lblFixHeading.Text = (mf.fixHeading * 57.2957795).ToString("N1");

            if (mf.isMetric)
            {
                    lblAltitude.Text = mf.Altitude;
                lblTotalFieldArea.Text = mf.fd.AreaBoundaryLessInnersHectares;
                lblTotalAppliedArea.Text = mf.fd.WorkedHectares;
                lblWorkRemaining.Text = mf.fd.WorkedAreaRemainHectares;
                lblPercentRemaining.Text = mf.fd.WorkedAreaRemainPercentage;
                lblTimeRemaining.Text = mf.fd.TimeTillFinished;
                lblEqSpec.Text = (Math.Round(mf.tool.ToolWidth, 2)).ToString() + " m  " + mf.vehicleFileName + mf.toolFileName;
            }
            else //imperial
            {
                lblAltitude.Text = mf.AltitudeFeet;
                lblTotalFieldArea.Text = mf.fd.AreaBoundaryLessInnersAcres;
                lblTotalAppliedArea.Text = mf.fd.WorkedAcres;
                lblWorkRemaining.Text = mf.fd.WorkedAreaRemainAcres;
                lblPercentRemaining.Text = mf.fd.WorkedAreaRemainPercentage;
                lblTimeRemaining.Text = mf.fd.TimeTillFinished;
                lblEqSpec.Text =  (Math.Round(mf.tool.ToolWidth * glm.m2ft, 2)).ToString() + " ft  " + mf.vehicleFileName + mf.toolFileName;
            }

            txtBoxRecvAutoSteer.Text = mf.mc.serialRecvAutoSteerStr;
            txtBoxRecvMachine.Text = mf.mc.serialRecvMachineStr;
        }

        private void FormGPSData_Load(object sender, EventArgs e)
        {
            lblConvergenceAngle.Text = Math.Round(glm.toDegrees(mf.pn.convergenceAngle), 3).ToString();
            lblSunrise.Text = mf.sunrise.ToString("HH:mm");
            lblSunset.Text = mf.sunset.ToString("HH:mm");

        }
    }
}


    //lblAreaAppliedMinusOverlap.Text = ((fd.actualAreaCovered * glm.m2ac).ToString("N2"));
    //lblAreaMinusActualApplied.Text = (((mf.fd.areaBoundaryOuterLessInner - mf.fd.actualAreaCovered) * glm.m2ac).ToString("N2"));
    //lblOverlapPercent.Text = (fd.overlapPercent.ToString("N2")) + "%";
    //lblAreaOverlapped.Text = (((fd.workedAreaTotal - fd.actualAreaCovered) * glm.m2ac).ToString("N3"));
            
    //lblAreaAppliedMinusOverlap.Text = ((fd.actualAreaCovered * glm.m2ha).ToString("N2"));
    //lblAreaMinusActualApplied.Text = (((mf.fd.areaBoundaryOuterLessInner - mf.fd.actualAreaCovered) * glm.m2ha).ToString("N2"));
    //lblOverlapPercent.Text = (fd.overlapPercent.ToString("N2")) + "%";
    //lblAreaOverlapped.Text = (((fd.workedAreaTotal - fd.actualAreaCovered) * glm.m2ha).ToString("N3"));


    //lblLookOnLeft.Text = mf.tool.lookAheadDistanceOnPixelsLeft.ToString("N0");
    //lblLookOnRight.Text = mf.tool.lookAheadDistanceOnPixelsRight.ToString("N0");
    //lblLookOffLeft.Text = mf.tool.lookAheadDistanceOffPixelsLeft.ToString("N0");
    //lblLookOffRight.Text = mf.tool.lookAheadDistanceOffPixelsRight.ToString("N0");

    //lblLeftToolSpd.Text = (mf.tool.toolFarLeftSpeed*3.6).ToString("N1");
    //lblRightToolSpd.Text = (mf.tool.toolFarRightSpeed*3.6).ToString("N1");

    //lblSectSpdLeft.Text = (mf.section[0].speedPixels*0.36).ToString("N1");
    //lblSectSpdRight.Text = (mf.section[mf.tool.numOfSections-1].speedPixels*0.36).ToString("N1");