﻿using DevDefined.OAuth.Consumer;

namespace YammerBot.Core.OAuth.Interface
{
    public interface IOauthSessionProvider
    {
        OAuthSession GetOAuthSession();
    }
}
