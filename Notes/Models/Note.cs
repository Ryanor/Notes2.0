﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Notes.Models
{
    public class Note
    {
        public string NoteTitle { get; set; }
        public string TextNote { get; set; }
        public DateTime Date { get; set; }

        public Note(string noteTitle, string textNote, DateTime date)
        {
            this.NoteTitle = noteTitle;
            this.TextNote = textNote;
            this.Date = date;
        }


        public string Title
        {
            get
            {
                if (NoteTitle.Length <= 15)
                {
                    return $"{NoteTitle}";
                }
                else
                {
                    return $"{NoteTitle}".Substring(0, 15) + $"...";
                }
            }
        }

        public string NoteContext
        {
            get
            {
                if (TextNote.Length <= 15)
                {

                    return $"{TextNote}";
                }
                else
                {
                    return $"{TextNote}".Substring(0, 15) + $"...";
                }
            }
        }

        public string FormattedDate => Date.ToString("dd-MM-yyyy / hh:mm:ss");
    }
}
