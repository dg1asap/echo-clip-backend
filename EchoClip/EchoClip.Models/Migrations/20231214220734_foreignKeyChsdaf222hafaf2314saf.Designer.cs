﻿// <auto-generated />
using System;
using EchoClip.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EchoClip.Models.Migrations
{
    [DbContext(typeof(DatabaseEchoClipContext))]
    [Migration("20231214220734_foreignKeyChsdaf222hafaf2314saf")]
    partial class foreignKeyChsdaf222hafaf2314saf
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("EchoClip.Models.Chats", b =>
                {
                    b.Property<Guid>("Chat_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("Owner_user_id")
                        .HasColumnType("uuid");

                    b.HasKey("Chat_id");

                    b.HasIndex("Owner_user_id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("EchoClip.Models.ChatsVoiceRecordings", b =>
                {
                    b.Property<Guid>("ChatId")
                        .HasColumnType("uuid")
                        .HasColumnName("Chat_id");

                    b.Property<Guid>("VoiceRecordingId")
                        .HasColumnType("uuid")
                        .HasColumnName("Voice_recording_id");

                    b.HasKey("ChatId", "VoiceRecordingId");

                    b.HasIndex("VoiceRecordingId");

                    b.ToTable("Chats_voice_recordings");
                });

            modelBuilder.Entity("EchoClip.Models.Users", b =>
                {
                    b.Property<Guid>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("User_id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EchoClip.Models.UsersWhoJoinedChats", b =>
                {
                    b.Property<Guid>("User_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Chat_id")
                        .HasColumnType("uuid");

                    b.HasKey("User_id", "Chat_id");

                    b.HasIndex("Chat_id");

                    b.ToTable("Users_who_joined_chats");
                });

            modelBuilder.Entity("EchoClip.Models.VoiceRecordings", b =>
                {
                    b.Property<Guid>("Voide_recoding_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("Owner_user_id")
                        .HasColumnType("uuid");

                    b.Property<byte[]>("Recording")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<DateTime>("Upload_data_time")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Voide_recoding_id");

                    b.ToTable("Voice_recordings");
                });

            modelBuilder.Entity("EchoClip.Models.Chats", b =>
                {
                    b.HasOne("EchoClip.Models.Users", "Owner_user")
                        .WithMany("Created_chats")
                        .HasForeignKey("Owner_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner_user");
                });

            modelBuilder.Entity("EchoClip.Models.ChatsVoiceRecordings", b =>
                {
                    b.HasOne("EchoClip.Models.Chats", "Chat")
                        .WithMany("ChatsVoiceRecordings")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EchoClip.Models.VoiceRecordings", "VoiceRecording")
                        .WithMany("ChatsVoiceRecordings")
                        .HasForeignKey("VoiceRecordingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("VoiceRecording");
                });

            modelBuilder.Entity("EchoClip.Models.UsersWhoJoinedChats", b =>
                {
                    b.HasOne("EchoClip.Models.Chats", "Chat")
                        .WithMany("Users_who_joined_chats")
                        .HasForeignKey("Chat_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EchoClip.Models.Users", "User")
                        .WithMany("Users_who_joined_chats")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EchoClip.Models.Chats", b =>
                {
                    b.Navigation("ChatsVoiceRecordings");

                    b.Navigation("Users_who_joined_chats");
                });

            modelBuilder.Entity("EchoClip.Models.Users", b =>
                {
                    b.Navigation("Created_chats");

                    b.Navigation("Users_who_joined_chats");
                });

            modelBuilder.Entity("EchoClip.Models.VoiceRecordings", b =>
                {
                    b.Navigation("ChatsVoiceRecordings");
                });
#pragma warning restore 612, 618
        }
    }
}
