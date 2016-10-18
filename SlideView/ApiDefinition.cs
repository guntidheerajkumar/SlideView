using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace SlideView
{
	// @protocol HHSlideViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface HHSlideViewDelegate
	{
		// @required -(NSInteger)numberOfSlideItemsInSlideView:(HHSlideView *)slideView;
		[Abstract]
		[Export("numberOfSlideItemsInSlideView:")]
		nint NumberOfSlideItemsInSlideView(HHSlideView slideView);

		// @required -(NSArray *)namesOfSlideItemsInSlideView:(HHSlideView *)slideView;
		[Abstract]
		[Export("namesOfSlideItemsInSlideView:")]
		NSObject[] NamesOfSlideItemsInSlideView(HHSlideView slideView);

		// @required -(NSArray *)childViewControllersInSlideView:(HHSlideView *)slideView;
		[Abstract]
		[Export("childViewControllersInSlideView:")]
		NSObject[] ChildViewControllersInSlideView(HHSlideView slideView);

		// @required -(void)slideView:(HHSlideView *)slideView didSelectItemAtIndex:(NSInteger)index;
		[Abstract]
		[Export("slideView:didSelectItemAtIndex:")]
		void SlideView(HHSlideView slideView, nint index);

		// @optional -(UIColor *)colorOfSliderInSlideView:(HHSlideView *)slideView;
		[Export("colorOfSliderInSlideView:")]
		UIColor ColorOfSliderInSlideView(HHSlideView slideView);

		// @optional -(UIColor *)colorOfSlideView:(HHSlideView *)slideView;
		[Export("colorOfSlideView:")]
		UIColor ColorOfSlideView(HHSlideView slideView);
	}

	// @interface HHSlideView : UIView
	[BaseType(typeof(UIView))]
	interface HHSlideView
	{
		[Wrap("WeakDelegate")]
		HHSlideViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<HHSlideViewDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, assign, nonatomic) NSInteger numberOfSlideItems;
		[Export("numberOfSlideItems")]
		nint NumberOfSlideItems { get; }

		// @property (readonly, nonatomic, strong) NSArray * namesOfSlideItems;
		[Export("namesOfSlideItems", ArgumentSemantic.Strong)]
		NSObject[] NamesOfSlideItems { get; }

		// @property (readonly, nonatomic, strong) UIColor * colorOfSlider;
		[Export("colorOfSlider", ArgumentSemantic.Strong)]
		UIColor ColorOfSlider { get; }

		// @property (readonly, nonatomic, strong) UIColor * colorOfSlideView;
		[Export("colorOfSlideView", ArgumentSemantic.Strong)]
		UIColor ColorOfSlideView { get; }
	}
}
