﻿using System;

using Foundation;
using ObjCRuntime;

namespace Firebase.Analytics
{
	// @interface FIRAnalytics : NSObject
	[BaseType (typeof (NSObject), Name = "FIRAnalytics")]
	interface Analytics
	{
		// +(void)logEventWithName:(NSString * _Nonnull)name parameters:(NSDictionary<NSString *,NSObject *> * _Nullable)parameters;
		[Static]
		[Export ("logEventWithName:parameters:")]
		void LogEvent (string name, [NullAllowed] NSDictionary<NSString, NSObject> parameters);

		// +(void)setUserPropertyString:(NSString * _Nullable)value forName:(NSString * _Nonnull)name;
		[Static]
		[Export ("setUserPropertyString:forName:")]
		void SetUserProperty ([NullAllowed] string value, string name);

		// +(void)setUserID:(NSString * _Nullable)userID;
		[Static]
		[Export ("setUserID:")]
		void SetUserID ([NullAllowed] string userID);

		// This method comes from a category (FIRAnalytics+AppDelegate.h)
		// +(void)handleEventsForBackgroundURLSession:(NSString *)identifier completionHandler:(void (^)(void))completionHandler;
		[Static]
		[Export ("handleEventsForBackgroundURLSession:completionHandler:")]
		void HandleEventsForBackgroundUrlSession (string identifier, [NullAllowed] Action completionHandler);

		// This method comes from a category (FIRAnalytics+AppDelegate.h)
		// +(void)handleOpenURL:(NSURL *)url;
		[Static]
		[Export ("handleOpenURL:")]
		void HandleOpenUrl (NSUrl url);

		// This method comes from a category (FIRAnalytics+AppDelegate.h)
		// +(void)handleUserActivity:(id)userActivity;
		[Static]
		[Export ("handleUserActivity:")]
		void HandleUserActivity (NSObject userActivity);

		// + (void)setScreenName:(nullable NSString *)screenName screenClass:(nullable NSString *)screenClassOverride;
		[Static]
		[Export ("setScreenName:screenClass:")]
		void SetScreenNameAndClass ([NullAllowed] string screenName, [NullAllowed] string screenClassOverride);

		// + (NSString *)appInstanceID;
		[Export ("appInstanceID")]
		string AppInstanceId { get; }
	}
}
