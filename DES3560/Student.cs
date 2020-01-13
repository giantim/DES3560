using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES3560
{
    public class Student
    {
        public int curriculumYear; // 교육과정 적용년도
        public string studentClass; // 학년
        public string studentId; // 학번
        public string name;
        public string major; // 학과
        public string minor; // 부전공
        public string submajor; // 복수전공
        public bool isEngineering; // 공학인증 심화대상

        public string formalUniv; // 전적대
        public string prevMajor; // 전과(학과)
        public string campusTransfer; // 캠퍼스 전입여부

        public List<Subject> rgcList;
        public List<Subject> priList;
        public List<Subject> cseList;
        public List<Subject> desList;

        public string allGrade;
        public string gpa;
        public string teaching;
        public string majorEng;
        public string otherEng;
        public string isEng;
        public string eng;
        public string isToeic;
        public string toeic;

        public bool rgcPass;
        public bool basicPass;
        public bool mscPass;
        public bool majorPass;
        public bool allGradePass;
        public bool gpaPass;
        public bool engResultPass;
        public bool engPass;
        public bool toeicPass;
        public bool paper;
        public bool engineeringPass;
        public bool graduationPass;
    }
}
