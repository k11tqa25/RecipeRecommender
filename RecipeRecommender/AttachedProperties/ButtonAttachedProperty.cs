﻿using System.Windows;
using System.Windows.Controls;

namespace RecipeRecommender
{
    /// <summary>
    /// The IsBusy attached property for anything that wants to flag if the control is busy
    /// </summary>
    public class IsBusyProperty: BaseAttachedProperty<IsBusyProperty, bool> 
    {
    }
}
