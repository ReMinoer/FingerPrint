﻿using Stave;

namespace Fingear
{
    public interface IControlContainer<TControls> : IContainer<IControl, IControlParent, TControls>, IControlParent
        where TControls : class, IControl
    {
    }

    public interface IControlContainer<TControls, TValue> : IControlContainer<TControls>, IControlParent<TValue>
        where TControls : class, IControl
    {
    }
}