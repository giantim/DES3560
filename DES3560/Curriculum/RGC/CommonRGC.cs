using System.Collections.Generic;

namespace DES3560.Curriculum.RGC
{
    public class CommonRGC
    {
        public int RGCGrade;

        public CommonRGC(List<Subject> list)
        {
            RGCGrade = 0;

            foreach (Subject s in list)
                RGCGrade = RGCGrade + s.subjectGrade;
        }
    }
}
