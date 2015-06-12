using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Mill_Project.Models.Mapping
{
    public class en_whs_extMap : EntityTypeConfiguration<en_whs_ext>
    {
        public en_whs_extMap()
        {
            // Primary Key
            this.HasKey(t => t.en_whs_key);

            // Properties
            this.Property(t => t.en_whs_key)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.ins_key1)
                .HasMaxLength(10);

            this.Property(t => t.ins_key2)
                .HasMaxLength(10);

            this.Property(t => t.ins_key3)
                .HasMaxLength(10);

            this.Property(t => t.ins_key4)
                .HasMaxLength(10);

            this.Property(t => t.ins_key5)
                .HasMaxLength(10);

            this.Property(t => t.ins_key6)
                .HasMaxLength(10);

            this.Property(t => t.ins_key7)
                .HasMaxLength(10);

            this.Property(t => t.ins_key8)
                .HasMaxLength(10);

            this.Property(t => t.ins_key9)
                .HasMaxLength(10);

            this.Property(t => t.ins_key10)
                .HasMaxLength(10);

            this.Property(t => t.ins_key11)
                .HasMaxLength(10);

            this.Property(t => t.ins_key12)
                .HasMaxLength(10);

            this.Property(t => t.ins_key13)
                .HasMaxLength(10);

            this.Property(t => t.ins_key14)
                .HasMaxLength(10);

            this.Property(t => t.ins_key15)
                .HasMaxLength(10);

            this.Property(t => t.ins_key16)
                .HasMaxLength(10);

            this.Property(t => t.ins_key17)
                .HasMaxLength(10);

            this.Property(t => t.ins_key18)
                .HasMaxLength(10);

            this.Property(t => t.ins_key19)
                .HasMaxLength(10);

            this.Property(t => t.ins_key20)
                .HasMaxLength(10);

            this.Property(t => t.ins_key21)
                .HasMaxLength(10);

            this.Property(t => t.ins_key22)
                .HasMaxLength(10);

            this.Property(t => t.ins_key23)
                .HasMaxLength(10);

            this.Property(t => t.ins_key24)
                .HasMaxLength(10);

            this.Property(t => t.ins_key25)
                .HasMaxLength(10);

            this.Property(t => t.ins_key26)
                .HasMaxLength(10);

            this.Property(t => t.ins_key27)
                .HasMaxLength(10);

            this.Property(t => t.ins_key28)
                .HasMaxLength(10);

            this.Property(t => t.ins_key29)
                .HasMaxLength(10);

            this.Property(t => t.ins_key30)
                .HasMaxLength(10);

            this.Property(t => t.ins_key31)
                .HasMaxLength(10);

            this.Property(t => t.ins_key32)
                .HasMaxLength(10);

            this.Property(t => t.ins_key33)
                .HasMaxLength(10);

            this.Property(t => t.ins_key34)
                .HasMaxLength(10);

            this.Property(t => t.ins_key35)
                .HasMaxLength(10);

            this.Property(t => t.en_ship_key)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("en_whs_ext");
            this.Property(t => t.en_whs_key).HasColumnName("en_whs_key");
            this.Property(t => t.ins_key1).HasColumnName("ins_key1");
            this.Property(t => t.ins_key2).HasColumnName("ins_key2");
            this.Property(t => t.ins_key3).HasColumnName("ins_key3");
            this.Property(t => t.ins_key4).HasColumnName("ins_key4");
            this.Property(t => t.ins_key5).HasColumnName("ins_key5");
            this.Property(t => t.ins_key6).HasColumnName("ins_key6");
            this.Property(t => t.ins_key7).HasColumnName("ins_key7");
            this.Property(t => t.ins_key8).HasColumnName("ins_key8");
            this.Property(t => t.ins_key9).HasColumnName("ins_key9");
            this.Property(t => t.ins_key10).HasColumnName("ins_key10");
            this.Property(t => t.ins_key11).HasColumnName("ins_key11");
            this.Property(t => t.ins_key12).HasColumnName("ins_key12");
            this.Property(t => t.ins_key13).HasColumnName("ins_key13");
            this.Property(t => t.ins_key14).HasColumnName("ins_key14");
            this.Property(t => t.ins_key15).HasColumnName("ins_key15");
            this.Property(t => t.ins_key16).HasColumnName("ins_key16");
            this.Property(t => t.ins_key17).HasColumnName("ins_key17");
            this.Property(t => t.ins_key18).HasColumnName("ins_key18");
            this.Property(t => t.ins_key19).HasColumnName("ins_key19");
            this.Property(t => t.ins_key20).HasColumnName("ins_key20");
            this.Property(t => t.ins_key21).HasColumnName("ins_key21");
            this.Property(t => t.ins_key22).HasColumnName("ins_key22");
            this.Property(t => t.ins_key23).HasColumnName("ins_key23");
            this.Property(t => t.ins_key24).HasColumnName("ins_key24");
            this.Property(t => t.ins_key25).HasColumnName("ins_key25");
            this.Property(t => t.ins_key26).HasColumnName("ins_key26");
            this.Property(t => t.ins_key27).HasColumnName("ins_key27");
            this.Property(t => t.ins_key28).HasColumnName("ins_key28");
            this.Property(t => t.ins_key29).HasColumnName("ins_key29");
            this.Property(t => t.ins_key30).HasColumnName("ins_key30");
            this.Property(t => t.ins_key31).HasColumnName("ins_key31");
            this.Property(t => t.ins_key32).HasColumnName("ins_key32");
            this.Property(t => t.ins_key33).HasColumnName("ins_key33");
            this.Property(t => t.ins_key34).HasColumnName("ins_key34");
            this.Property(t => t.ins_key35).HasColumnName("ins_key35");
            this.Property(t => t.en_ship_key).HasColumnName("en_ship_key");
            this.Property(t => t.en_whs_upcnt).HasColumnName("en_whs_upcnt");
        }
    }
}
