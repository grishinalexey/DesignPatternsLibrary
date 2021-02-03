﻿using BuildingBlocks;

namespace LazyLoadLibrary.ValueHolderExample
{
    public static class ValueHolderExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Value holder example");

            var collegeFactory = new CollegeFactory();
            var college = collegeFactory.CreateFromId(1);

            college.ShowDetails();
        }
    }
}
