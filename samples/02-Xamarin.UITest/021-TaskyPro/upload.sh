#!/bin/bash

. ./upload.secret.sh

# http://developer.xamarin.com/guides/testcloud/uitest/working-with/submitting-tests-at-command-line/
mono \
	packages/Xamarin.UITest.$VERSION/tools/test-cloud.exe \
		submit \
		$FILE_APK \
		$API_KEY_TEAM \
		--devices $DEVICES \
		--series "master" \
		--locale "en_US" \
		--user $USER \
		--assembly-dir $PATH_TO_TEST_NUNIT_DLL_FOLDER

		
		
