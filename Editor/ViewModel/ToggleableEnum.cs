using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.ViewModel
{
    public class ToggleableEnum<T> where T: Enum
    {
        public bool IsActive { get; set; }
        public T Current { get; set; }

        public ToggleableEnum(T current, bool isActive)
        {
            IsActive = isActive;
            Current = current;
        }
    }
}