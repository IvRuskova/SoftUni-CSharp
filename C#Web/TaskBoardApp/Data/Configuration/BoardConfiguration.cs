﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskBoardApp.Data.Configuration
{
    public class BoardConfiguration : IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            builder.HasData(new Board[] 
            {
                ConfigurationHelper.InProgressBoard,
                ConfigurationHelper.OpenBoard,
                ConfigurationHelper.DoneBoard
            });
        }
    }
}
