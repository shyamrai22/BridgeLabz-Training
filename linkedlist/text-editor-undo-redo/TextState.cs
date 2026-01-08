using System;

namespace BridgeLabzTraining.dsa_csharp_practice.undo_redo_text_editor
{
    class TextState
    {
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public TextState(string content)
        {
            this.content = content;
        }
    }
}
