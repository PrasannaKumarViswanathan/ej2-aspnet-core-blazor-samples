﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> DataGrid { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "Grid/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Sorting",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "Grid/Sorting",
                FileName = "Sorting.razor",
                Type = SampleType.New
            },              
            new Sample
            {
                Name = "Filtering",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "Grid/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Inline Editing",
                Category = "DataGrid",
                Directory = "Grid/DataGrid",
                Url = "Grid/InlineEditing",
                FileName = "InlineEditing.razor",
                Type = SampleType.New
            }
        };      
    }
}
