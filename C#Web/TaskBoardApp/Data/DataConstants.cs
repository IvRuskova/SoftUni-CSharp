﻿namespace TaskBoardApp.Data
{
    public static class DataConstants
    {
        public static class Task
        {
            public const int TitleMaxLength = 70;
            public const int TitleMinLength = 5;
            public const int DescriptionMaxLength = 1000;
            public const int DescriptionMinLength = 10;
        }
        public static class Board
        {
            public const int NameMaxLength = 30;
            public static int NameMinLength = 3;
        }
    }
    
}
