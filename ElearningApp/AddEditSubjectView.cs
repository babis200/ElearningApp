using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ElearningModels;

using ElearningServices;

using MaterialSkin2DotNet.Controls;

using static ElearningApp.AppEnums;

namespace ElearningApp
{
    public partial class AddEditSubjectView : MaterialForm
    {
        Work _workType;
        SubjectModel _subject;
        SubjectService _service;
        Action _updateParent;

        public AddEditSubjectView(Work workType, SubjectModel subject, SubjectService service, Action updateParent)
        {
            InitializeComponent();
            _workType = workType;
            _subject = subject;
            _service = service;
            _updateParent = updateParent;
        }


    }
}
