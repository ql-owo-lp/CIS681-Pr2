﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kevin.CIS681.Project.CodeAnalyzer.Parser.Grammar {
    interface ILoader {
        object this[string index] {get;}
    }
}
