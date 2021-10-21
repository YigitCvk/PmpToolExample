using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModel
{
    public class BoardViewModel
    {
        public List<Board> Board { get; set; }
        public List<BoardTask> BoardTask { get; set; }
    }
}
