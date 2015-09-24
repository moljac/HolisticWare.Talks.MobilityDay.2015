
Call .\upload.secret.bat


packages\Xamarin.UITest.%VERSION%\tools\test-cloud.exe ^ 
	submit ^
		%FILE_APK% ^
		%API_KEY_TEAM% ^
		--devices %DEVICES% ^
		--series "master" ^
		--locale "en_US" ^
		--user %USER% ^
		--assembly-dir 
