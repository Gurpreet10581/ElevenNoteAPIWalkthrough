using System;

namespace ElevenNote.Services
{
    internal class NoteListItem
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }

        //will have to do below to get access and get below properties in postman
        //public int CategoryID { get; set; }
        //public string CategoryName { get; set; }
    }
}