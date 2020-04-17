using System;

namespace ElevenNote.Services
{
    internal class NoteListItem
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}