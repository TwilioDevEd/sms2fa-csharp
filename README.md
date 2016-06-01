<a href="https://www.twilio.com">
  <img src="https://static0.twilio.com/marketing/bundles/marketing/img/logos/wordmark-red.svg" alt="Twilio" width="250" />
</a>

# SMS Two-Factor Authentication

[![Build status](https://ci.appveyor.com/api/projects/status/bi338rcmhm1x9bx4?svg=true)](https://ci.appveyor.com/project/TwilioDevEd/sms2fa-csharp)

SMS Two-Factor Authentication (SMS-2FA) helps keep your user accounts secure by
validating two "factors" of identity. Most login systems only validate a password
known by the user. You can make it harder for evildoers to compromise a user account
by also validating something a user has, such as their mobile phone.

## Local development

This project is built using [ASP.NET MVC](http://www.asp.net/mvc) Framework.

1. First clone this repository and `cd` into it.

   ```shell
   git clone git@github.com:TwilioDevEd/sms2fa-csharp.git
   cd sms2fa-csharp
   ```

1. Rename the sample configuration file and edit it to match your configuration.

   ```shell
   rename SMS2FA.Web\Local.config.example SMS2FA.Web\Local.config
   ```

   You can find your `AccountSid` and `AuthToken` in your
   [Twilio Account Settings](https://www.twilio.com/user/account/settings).
   You will also need a `TwilioNumber`, you may find it [here](https://www.twilio.com/user/account/phone-numbers/incoming).

1. Build the solution.

1. Create database and run migrations.

   Make sure SQL Server is up and running.  
   In Visual Studio, open the following command in the [Package Manager
   Console](https://docs.nuget.org/consume/package-manager-console).

   ```shell
   Update-Database
   ```

1. Run the application.

1. Check it out at [http://localhost:50046](http://localhost:50046).

## Meta

* No warranty expressed or implied. Software is as is. Diggity.
* [MIT License](http://www.opensource.org/licenses/mit-license.html)
* Lovingly crafted by Twilio Developer Education.
