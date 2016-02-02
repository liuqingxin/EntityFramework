using OracleCodeFirst.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleCodeFirst.Models
{
    [View]
    public class ViewTest
    {
        /// <summary>
        /// 学号
        /// </summary>
        [Key]
        [Column("XH")]
        public string Code
        {
            get;
            set;
        }

        /// <summary>
        /// 姓名
        /// </summary>
        [Column("XM")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 性别
        /// </summary>
        [Column("XB")]
        public string Sex
        {
            get;
            set;
        }

        /// <summary>
        /// 当前所在级
        /// </summary>
        [Column("DQSZJ")]
        public string CurrentSchoolRoll
        {
            get;
            set;
        }

        /// <summary>
        /// 学院代码
        /// </summary>
        [Column("XYDM")]
        public string CollegeCode
        {
            get;
            set;
        }

        /// <summary>
        /// 专业代码
        /// </summary>
        [Column("ZYDM")]
        public string DisciplineCode
        {
            get;
            set;
        }

        /// <summary>
        /// 学制
        /// </summary>
        [Column("XZ")]
        public string DurationStudy
        {
            get;
            set;
        }

        /// <summary>
        /// 班级
        /// </summary>
        [Column("XZB")]
        public string ClassCode
        {
            get;
            set;
        }

        /// <summary>
        /// 是否在校
        /// </summary>
        [Column("SFZX")]
        public string IsAtSchool
        {
            get;
            set;
        }

        /// <summary>
        /// 学籍状态
        /// </summary>
        [Column("XJZT")]
        public string SchoolRollStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 学生类型（本专科，研究生)
        /// </summary>
        [Column("XSLX")]
        public string StudentType
        {
            get;
            set;
        }
    }
}
