﻿using Cofoundry.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cofoundry.Samples.SimpleSite
{
    public class ContentSplitSectionDisplayModel : IPageModuleDisplayModel
    {
        public string Title { get; set; }

        public HtmlString HtmlText { get; set; }

        public ImageAssetRenderDetails Image { get; set; }
    }
}