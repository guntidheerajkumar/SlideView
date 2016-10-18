
#import <UIKit/UIKit.h>

@class HHSlideView;
@protocol HHSlideViewDelegate <NSObject>

@required
- (NSInteger)numberOfSlideItemsInSlideView:(HHSlideView *)slideView;

- (NSArray *)namesOfSlideItemsInSlideView:(HHSlideView *)slideView;

- (NSArray *)childViewControllersInSlideView:(HHSlideView *)slideView;

- (void)slideView:(HHSlideView *)slideView didSelectItemAtIndex:(NSInteger)index;

@optional
- (UIColor *)colorOfSliderInSlideView:(HHSlideView *)slideView;

- (UIColor *)colorOfSlideView:(HHSlideView *)slideView;

@end


@interface HHSlideView : UIView

@property (weak, nonatomic) id<HHSlideViewDelegate> delegate;

@property (assign, nonatomic, readonly) NSInteger numberOfSlideItems;

@property (strong, nonatomic, readonly) NSArray *namesOfSlideItems;
@property (strong, nonatomic, readonly) UIColor *colorOfSlider;

@property (strong, nonatomic, readonly) UIColor *colorOfSlideView;

@end


