﻿using Cofoundry.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cofoundry.Samples.SimpleSite
{
    public class ContentSplitSectionDataModel : IPageModuleDataModel
    {
        [Display(Description = "Optional title to display at the top of the section")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Text", Description = "Rich text displayed alongside the image")]
        [Html(HtmlToolbarPreset.BasicFormatting, HtmlToolbarPreset.Headings)]
        public string HtmlText { get; set; }

        [Display(Description = "Image to display alongside the text")]
        [Image(MinWidth = 400, MinHeight = 400)]
        public int ImageAssetId { get; set; }
    }
}