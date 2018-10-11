﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnSolve.Mobile.Data;

namespace OnSolve.Mobile.Data.Migrations
{
    [DbContext(typeof(OnSolveMobileContext))]
    partial class OnSolveMobileContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnSolve.Mobile.Data.Entites.ConferenceBridgeDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConferencePhoneNumber");

                    b.Property<bool>("IsSendConferenceIdInMessage");

                    b.Property<bool>("IsSendConferencePhoneInMessage");

                    b.Property<string>("ParticipantCode");

                    b.HasKey("Id");

                    b.ToTable("ConferenceBridgeDetails");
                });

            modelBuilder.Entity("OnSolve.Mobile.Data.Entites.EmailVerificationCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("EmailVerificationCode");
                });

            modelBuilder.Entity("OnSolve.Mobile.Data.Entites.FCMTokenInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FCMToken")
                        .IsRequired();

                    b.Property<int>("MobileUserId");

                    b.HasKey("Id");

                    b.HasIndex("MobileUserId");

                    b.ToTable("FCMTokenInfo");
                });

            modelBuilder.Entity("OnSolve.Mobile.Data.Entites.MessageDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ConferenceBridgeDetailId");

                    b.Property<long>("ContactPointId");

                    b.Property<DateTime>("DateTimeSent");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<bool>("IsConference");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsGetWordBack");

                    b.Property<bool>("IsRead");

                    b.Property<bool>("IsVanishEnabled");

                    b.Property<long>("MessageId");

                    b.Property<int?>("MessageSenderDetailId");

                    b.Property<long>("MessageTransactionId");

                    b.Property<int>("MessageType");

                    b.Property<int?>("MobileUserId");

                    b.Property<long>("RecipientId");

                    b.Property<bool>("ResponseRecieved");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ConferenceBridgeDetailId");

                    b.HasIndex("MessageSenderDetailId");

                    b.HasIndex("MobileUserId");

                    b.ToTable("MessageDetails");
                });

            modelBuilder.Entity("OnSolve.Mobile.Data.Entites.MessageSenderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SenderEmail");

                    b.Property<string>("SenderFullName");

                    b.Property<string>("SenderPhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("MessageSenderDetails");
                });

            modelBuilder.Entity("OnSolve.Mobile.Data.Entites.MobileRecipient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("MobileUserId");

                    b.HasKey("Id");

                    b.ToTable("MobileRecipients");
                });

            modelBuilder.Entity("OnSolve.Mobile.Data.Entites.MobileUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<long?>("ENSUserId");

                    b.Property<string>("Password");

                    b.Property<long>("RecipientId");

                    b.Property<string>("Salt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("MobileUser");
                });

            modelBuilder.Entity("OnSolve.Mobile.Data.Entites.ResetPasswordCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("MobileUserId");

                    b.Property<string>("ResetCode")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("MobileUserId");

                    b.ToTable("ResetPasswordCode");
                });

            modelBuilder.Entity("OnSolve.Mobile.Data.Entites.FCMTokenInfo", b =>
                {
                    b.HasOne("OnSolve.Mobile.Data.Entites.MobileUser", "MobileUser")
                        .WithMany("FCMTokenInfo")
                        .HasForeignKey("MobileUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnSolve.Mobile.Data.Entites.MessageDetail", b =>
                {
                    b.HasOne("OnSolve.Mobile.Data.Entites.ConferenceBridgeDetail", "ConferenceBridgeDetail")
                        .WithMany()
                        .HasForeignKey("ConferenceBridgeDetailId");

                    b.HasOne("OnSolve.Mobile.Data.Entites.MessageSenderDetail", "MessageSenderDetail")
                        .WithMany()
                        .HasForeignKey("MessageSenderDetailId");

                    b.HasOne("OnSolve.Mobile.Data.Entites.MobileUser", "MobileUser")
                        .WithMany("Messages")
                        .HasForeignKey("MobileUserId");
                });

            modelBuilder.Entity("OnSolve.Mobile.Data.Entites.ResetPasswordCode", b =>
                {
                    b.HasOne("OnSolve.Mobile.Data.Entites.MobileUser", "MobileUser")
                        .WithMany()
                        .HasForeignKey("MobileUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
