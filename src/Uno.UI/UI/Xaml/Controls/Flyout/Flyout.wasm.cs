﻿using System;
using System.Collections.Generic;
using System.Text;
using Uno.Extensions;
using Uno.Logging;
using Uno.UI.Extensions;
using Uno.Disposables;
using Uno.UI.DataBinding;
using Uno.UI;

namespace Windows.UI.Xaml.Controls
{
	public partial class Flyout
	{
		partial void SetPopupPositionPartial(UIElement placementTarget)
		{
			_popup.Anchor = placementTarget;
			_popup.AnchorPlacement = Placement;
		}
	}
}
