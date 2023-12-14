﻿// <auto-generated />
using System;
using EchoClip.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EchoClip.Models.Migrations
{
    [DbContext(typeof(DatabaseEchoClipContext))]
    partial class DatabaseEchoClipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("EchoClip.Models.Chat", b =>
                {
                    b.Property<Guid>("ChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Chat_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("OwnerUserId")
                        .HasColumnType("uuid")
                        .HasColumnName("Owner_user_id");

                    b.HasKey("ChatId");

                    b.HasIndex("OwnerUserId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("EchoClip.Models.ChatsVoiceRecording", b =>
                {
                    b.Property<Guid>("ChatId")
                        .HasColumnType("uuid")
                        .HasColumnName("Chat_id");

                    b.Property<Guid>("VoiceRecordingId")
                        .HasColumnType("uuid")
                        .HasColumnName("Voice_recording_id");

                    b.Property<DateTime>("DataOfAdded")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Date_of_added");

                    b.HasKey("ChatId", "VoiceRecordingId");

                    b.HasIndex("DataOfAdded")
                        .IsUnique();

                    b.HasIndex("VoiceRecordingId");

                    b.ToTable("Chats_voice_recordings");
                });

            modelBuilder.Entity("EchoClip.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("User_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EchoClip.Models.UserWhoJoinedChat", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("User_id");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uuid")
                        .HasColumnName("Chat_id");

                    b.HasKey("UserId", "ChatId");

                    b.HasIndex("ChatId");

                    b.ToTable("Users_who_joined_chats");
                });

            modelBuilder.Entity("EchoClip.Models.VoiceRecording", b =>
                {
                    b.Property<Guid>("VoiceRecodingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Voice_recording_id");

                    b.Property<Guid>("OwnerUserId")
                        .HasColumnType("uuid")
                        .HasColumnName("Owner_user_id");

                    b.Property<byte[]>("Recording")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<DateTime>("UploadDataTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Upload_data_time");

                    b.HasKey("VoiceRecodingId");

                    b.HasIndex("OwnerUserId");

                    b.ToTable("Voice_recordings");
                });

            modelBuilder.Entity("EchoClip.Models.Chat", b =>
                {
                    b.HasOne("EchoClip.Models.User", "OwnerUser")
                        .WithMany("CreatedChats")
                        .HasForeignKey("OwnerUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OwnerUser");
                });

            modelBuilder.Entity("EchoClip.Models.ChatsVoiceRecording", b =>
                {
                    b.HasOne("EchoClip.Models.Chat", "Chat")
                        .WithMany("ChatsVoiceRecordings")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EchoClip.Models.VoiceRecording", "VoiceRecording")
                        .WithMany("ChatsVoiceRecordings")
                        .HasForeignKey("VoiceRecordingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("VoiceRecording");
                });

            modelBuilder.Entity("EchoClip.Models.UserWhoJoinedChat", b =>
                {
                    b.HasOne("EchoClip.Models.Chat", "Chat")
                        .WithMany("UsersWhoJoinedChats")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EchoClip.Models.User", "User")
                        .WithMany("UsersWhoJoinedChats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EchoClip.Models.VoiceRecording", b =>
                {
                    b.HasOne("EchoClip.Models.User", "OwnerUser")
                        .WithMany("VoiceRecordings")
                        .HasForeignKey("OwnerUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OwnerUser");
                });

            modelBuilder.Entity("EchoClip.Models.Chat", b =>
                {
                    b.Navigation("ChatsVoiceRecordings");

                    b.Navigation("UsersWhoJoinedChats");
                });

            modelBuilder.Entity("EchoClip.Models.User", b =>
                {
                    b.Navigation("CreatedChats");

                    b.Navigation("UsersWhoJoinedChats");

                    b.Navigation("VoiceRecordings");
                });

            modelBuilder.Entity("EchoClip.Models.VoiceRecording", b =>
                {
                    b.Navigation("ChatsVoiceRecordings");
                });
#pragma warning restore 612, 618
        }
    }
}
