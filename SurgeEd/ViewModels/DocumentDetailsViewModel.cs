﻿using System;
using System.Collections.Generic;

namespace SurgeEd.ViewModels
{
    public class DocumentDetailsViewModel
    {
        public int DocumentId { get; set; }
        public string Title { get; set; }
        public Byte[] Contents { get; set; }
        public DateTime UploadDate { get; set; }
        public string UploadUserId { get; set; }
        public List<DocumentViewModel> Documents { get; set; }
    }
}