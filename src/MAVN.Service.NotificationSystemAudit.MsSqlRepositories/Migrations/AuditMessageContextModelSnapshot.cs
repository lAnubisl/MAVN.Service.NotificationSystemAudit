// <auto-generated />
using System;
using MAVN.Service.NotificationSystemAudit.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.NotificationSystemAudit.MsSqlRepositories.Migrations
{
    [DbContext(typeof(AuditMessageContext))]
    partial class AuditMessageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("auditmessage")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.NotificationSystemAudit.MsSqlRepositories.Entities.AuditMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("CallType")
                        .HasColumnName("call_type")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreationTimestamp")
                        .HasColumnName("creation_timestamp");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id")
                        .HasMaxLength(100);

                    b.Property<string>("DeliveryComment")
                        .HasColumnName("delivery_comment")
                        .HasMaxLength(10000);

                    b.Property<int>("DeliveryStatus")
                        .HasColumnName("delivery_status")
                        .HasMaxLength(40);

                    b.Property<string>("FormattingComment")
                        .HasColumnName("formatting_comment")
                        .HasMaxLength(10000);

                    b.Property<int>("FormattingStatus")
                        .HasColumnName("formatting_status")
                        .HasMaxLength(40);

                    b.Property<string>("MessageGroupId")
                        .HasColumnName("message_group_id")
                        .HasMaxLength(100);

                    b.Property<string>("MessageId")
                        .IsRequired()
                        .HasColumnName("message_id")
                        .HasMaxLength(100);

                    b.Property<string>("MessageTemplateId")
                        .IsRequired()
                        .HasColumnName("message_template_id")
                        .HasMaxLength(100);

                    b.Property<string>("MessageType")
                        .IsRequired()
                        .HasColumnName("message_type")
                        .HasMaxLength(30);

                    b.Property<DateTime>("SentTimestamp")
                        .HasColumnName("sent_timestamp");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnName("source")
                        .HasMaxLength(100);

                    b.Property<string>("SubjectTemplateId")
                        .HasColumnName("subject_template_id")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DeliveryStatus");

                    b.HasIndex("MessageGroupId");

                    b.HasIndex("MessageId");

                    b.HasIndex("MessageType");

                    b.HasIndex("SentTimestamp");

                    b.HasIndex("Source");

                    b.ToTable("audit_messages");
                });
#pragma warning restore 612, 618
        }
    }
}
