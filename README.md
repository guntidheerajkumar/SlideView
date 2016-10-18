# SlideView
> SlideView which is similar to Pivot Menu in Windows.

This is a binding project done based on https://www.cocoacontrols.com/controls/hhslideview Courtesy to Herbert77.

## Usage

``` 
HHSlideView sView = new HHSlideView();
sView.Frame = new CGRect(0, 64, this.View.Frame.Width, this.View.Frame.Height - 64);
sView.Delegate = new SlideDelegate();
this.View.AddSubview(sView);
```

```
public class SlideDelegate : HHSlideViewDelegate
{
	public override NSObject[] ChildViewControllersInSlideView(HHSlideView slideView)
	{
		var first = UIStoryboard.FromName("Main", null).InstantiateViewController("FirstController");
		var second = UIStoryboard.FromName("Main", null).InstantiateViewController("SecondController");
		var third = UIStoryboard.FromName("Main", null).InstantiateViewController("ThirdController");
		NSObject[] controllerArray = { first, second, third };
		return controllerArray;
	}

    public override NSObject[] NamesOfSlideItemsInSlideView(HHSlideView slideView)
    {
		NSObject[] names = { new NSString("First"), new NSString(@"Second"), new NSString("Third") };
		return names;
	}

	public override nint NumberOfSlideItemsInSlideView(HHSlideView slideView)
	{
		return 3;
	}

	public override void SlideView(HHSlideView slideView, nint index)
	{
		Console.WriteLine($"Selected Index: { index }");
	}

	public override UIColor ColorOfSlideView(HHSlideView slideView)
	{
		return UIColor.Black;
	}

	public override UIColor ColorOfSliderInSlideView(HHSlideView slideView)
	{
		return UIColor.Red;
	}
}
```
