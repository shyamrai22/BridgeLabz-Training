namespace BridgeLabzTraining.dsa_csharp_practice.undo_redo_text_editor
{
    class DoublyNode
    {
        public TextState Data;
        public DoublyNode Previous;
        public DoublyNode Next;

        public DoublyNode(TextState state)
        {
            Data = state;
            Previous = null;
            Next = null;
        }
    }
}
