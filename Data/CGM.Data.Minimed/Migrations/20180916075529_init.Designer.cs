﻿// <auto-generated />
using System;
using CGM.Data.Minimed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CGM.Data.Minimed.Migrations
{
    [DbContext(typeof(MinimedContext))]
    [Migration("20180916075529_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("CGM.Data.Minimed.Model.BayerStick", b =>
                {
                    b.Property<int>("BayerStickId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccessPassword");

                    b.Property<string>("AllBytesAsString");

                    b.Property<string>("AnalogEngineVersion");

                    b.Property<string>("DigitalEngineVersion");

                    b.Property<string>("GameBoardVersion");

                    b.Property<string>("HMACbyte");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("MeterLanguage");

                    b.Property<string>("ModelNumber");

                    b.Property<string>("Name");

                    b.Property<string>("RFID");

                    b.Property<string>("SerialNum");

                    b.Property<string>("SerialNumSmall");

                    b.Property<string>("SerialNumber");

                    b.Property<string>("SerialNumberFull");

                    b.Property<string>("SkuIdentifier");

                    b.Property<string>("TestReminderInterval");

                    b.Property<string>("Value");

                    b.HasKey("BayerStickId");

                    b.ToTable("BayerStick");
                });

            modelBuilder.Entity("CGM.Data.Minimed.Model.Pump", b =>
                {
                    b.Property<int>("PumpId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("BgUnitRaw");

                    b.Property<string>("BytesAsString");

                    b.Property<string>("Firmware");

                    b.Property<string>("FirmwareAlphaNumber");

                    b.Property<byte>("FirmwareMajorNumber");

                    b.Property<byte>("FirmwareMinorNumber");

                    b.Property<string>("Mac");

                    b.Property<string>("Motor");

                    b.Property<string>("MotorAlphaNumber");

                    b.Property<byte>("MotorMajorNumber");

                    b.Property<byte>("MotorMinorNumber");

                    b.Property<string>("SerialNumber");

                    b.HasKey("PumpId");

                    b.ToTable("Pump");
                });

            modelBuilder.Entity("CGM.Data.Minimed.Model.PumpEvent", b =>
                {
                    b.Property<int>("PumpEventId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BayerStickId");

                    b.Property<string>("BytesAsString");

                    b.Property<DateTime>("EventDate");

                    b.Property<byte>("EventTypeRaw");

                    b.Property<byte>("Length");

                    b.Property<int>("Offset");

                    b.Property<int>("PumpId");

                    b.Property<int>("Rtc");

                    b.Property<byte>("Source");

                    b.Property<string>("Title");

                    b.HasKey("PumpEventId");

                    b.HasIndex("BayerStickId");

                    b.HasIndex("PumpId");

                    b.ToTable("PumpEvent");
                });

            modelBuilder.Entity("CGM.Data.Minimed.Model.PumpStatus", b =>
                {
                    b.Property<int>("PumpStatusId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("ActiveBasalPattern");

                    b.Property<double>("ActiveInsulin");

                    b.Property<int>("ActiveInsulinRaw");

                    b.Property<short>("Alert");

                    b.Property<DateTime?>("AlertDateTime");

                    b.Property<string>("AlertName");

                    b.Property<double>("BasalUnitsDeliveredToday");

                    b.Property<int>("BasalUnitsDeliveredTodayRaw");

                    b.Property<byte>("BatteryPercentage");

                    b.Property<double>("BolusEstimate");

                    b.Property<int>("BolusWizardBGL");

                    b.Property<short>("BolusWizardBGLRaw");

                    b.Property<byte>("BolusWizardRecent");

                    b.Property<string>("BytesAsString");

                    b.Property<byte>("CgmTrend");

                    b.Property<byte>("InsulinHours");

                    b.Property<byte>("InsulinMinutes");

                    b.Property<int>("LastBolusAmount");

                    b.Property<DateTime?>("LastBolusDateTime");

                    b.Property<short>("LastBolusReference");

                    b.Property<int>("LastBolusTime");

                    b.Property<byte>("LowSuspendActive");

                    b.Property<double>("NormalBasal");

                    b.Property<int>("NormalBasalRaw");

                    b.Property<int>("NowBolusingAmountDelivered");

                    b.Property<short>("NowBolusingMinutesRemaining");

                    b.Property<short>("NowBolusingReference");

                    b.Property<bool>("PS_BolusingDual");

                    b.Property<bool>("PS_BolusingNormal");

                    b.Property<bool>("PS_BolusingSquare");

                    b.Property<bool>("PS_CgmActive");

                    b.Property<bool>("PS_DeliveringInsulin");

                    b.Property<bool>("PS_Suspended");

                    b.Property<bool>("PS_TempBasalActive");

                    b.Property<int>("PumpId");

                    b.Property<DateTime>("PumpStatusDateTime");

                    b.Property<double>("ReservoirAmount");

                    b.Property<int>("ReservoirAmountRaw");

                    b.Property<bool>("SS_Calibrating");

                    b.Property<bool>("SS_CalibrationComplete");

                    b.Property<bool>("SS_Exception");

                    b.Property<int>("SensorBattery");

                    b.Property<byte>("SensorBatteryRaw");

                    b.Property<DateTime?>("SensorCalibrationDateTime");

                    b.Property<short>("SensorCalibrationMinutesRemaining");

                    b.Property<short>("SensorRateOfChangeRaw");

                    b.Property<byte>("SensorStatusFlag");

                    b.Property<int>("Sgv");

                    b.Property<DateTime>("SgvDateTime");

                    b.Property<double>("SgvMmol");

                    b.Property<short>("SgvRaw");

                    b.Property<byte>("StatusFlag");

                    b.Property<int>("TempBasal");

                    b.Property<short>("TempBasalMinutesRemaining");

                    b.Property<byte>("TempBasalPercentage");

                    b.Property<int>("Unknown1");

                    b.Property<byte>("Unknown3");

                    b.Property<byte[]>("Unknown6");

                    b.HasKey("PumpStatusId");

                    b.HasIndex("PumpId");

                    b.ToTable("PumpStatus");
                });

            modelBuilder.Entity("CGM.Data.Minimed.Model.SensorEvent", b =>
                {
                    b.Property<int>("SensorEventId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BayerStickId");

                    b.Property<string>("BytesAsString");

                    b.Property<DateTime>("EventDate");

                    b.Property<byte>("EventTypeRaw");

                    b.Property<byte>("Length");

                    b.Property<int>("Offset");

                    b.Property<int>("PumpId");

                    b.Property<int>("Rtc");

                    b.Property<byte>("Source");

                    b.Property<string>("Title");

                    b.HasKey("SensorEventId");

                    b.HasIndex("BayerStickId");

                    b.HasIndex("PumpId");

                    b.ToTable("SensorEvent");
                });

            modelBuilder.Entity("CGM.Data.Minimed.Model.SensorReading", b =>
                {
                    b.Property<int>("SgReadingId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<short>("IsigRaw");

                    b.Property<ushort>("PredictedSg");

                    b.Property<short>("RateOfChangeRaw");

                    b.Property<DateTime>("ReadingDateTime");

                    b.Property<int>("SensorEventId");

                    b.Property<byte>("SensorStatus");

                    b.Property<byte>("SgvRaw1");

                    b.Property<byte>("SgvRaw2");

                    b.HasKey("SgReadingId");

                    b.HasIndex("SensorEventId");

                    b.ToTable("SensorReading");
                });

            modelBuilder.Entity("CGM.Data.Minimed.Model.PumpEvent", b =>
                {
                    b.HasOne("CGM.Data.Minimed.Model.BayerStick", "BayerStick")
                        .WithMany("PumpEvents")
                        .HasForeignKey("BayerStickId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CGM.Data.Minimed.Model.Pump", "Pump")
                        .WithMany("PumpEvents")
                        .HasForeignKey("PumpId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CGM.Data.Minimed.Model.PumpStatus", b =>
                {
                    b.HasOne("CGM.Data.Minimed.Model.Pump", "Pump")
                        .WithMany("PumpStatus")
                        .HasForeignKey("PumpId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CGM.Data.Minimed.Model.SensorEvent", b =>
                {
                    b.HasOne("CGM.Data.Minimed.Model.BayerStick", "BayerStick")
                        .WithMany()
                        .HasForeignKey("BayerStickId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CGM.Data.Minimed.Model.Pump", "Pump")
                        .WithMany("SensorEvents")
                        .HasForeignKey("PumpId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CGM.Data.Minimed.Model.SensorReading", b =>
                {
                    b.HasOne("CGM.Data.Minimed.Model.SensorEvent", "SensorEvent")
                        .WithMany("SensorReadings")
                        .HasForeignKey("SensorEventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
