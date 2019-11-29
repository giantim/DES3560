namespace DES3560
{
    public class Subject
    {
        public string subjectID;
        public string subjectName;
        public int subjectGrade;
        public string subjectCategory;

        public bool compare(Subject s)
        {
            if (this.subjectID.Equals(s.subjectID))
                return true;
            return false;
        }
    }
}
