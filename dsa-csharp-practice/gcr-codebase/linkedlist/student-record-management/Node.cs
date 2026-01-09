namespace BridgeLabzTraining.dsa_csharp_practice.student_record_management
{
    class Node
    {
        public Student Data;
        public Node Next;

        public Node(Student student)
        {
            Data = student;
            Next = null;
        }
    }
}
