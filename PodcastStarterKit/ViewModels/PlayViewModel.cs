﻿﻿//    -------------------------------------------------------------------------------------------- 
//    Copyright (c) 2011 Microsoft Corporation.  All rights reserved. 
//    Use of this sample source code is subject to the terms of the Microsoft license 
//    agreement under which you licensed this sample source code and is provided AS-IS. 
//    If you did not accept the terms of the license agreement, you are not authorized 
//    to use this sample source code.  For the terms of the license, please see the 
//    license agreement between you and Microsoft. 
﻿//    -------------------------------------------------------------------------------------------- 

 namespace PodcastStarterKit.ViewModels
{
    public class PlayViewModel : ViewModelBase
    {
        public PlayViewModel()
        {
            Podcast = App.CurrentItem;            
        }

        private PodcastItemModel _podcast;
        public PodcastItemModel Podcast
        {
            get { return _podcast; }
            set
            {
                if (_podcast == value)
                    return;
                _podcast = value;
                NotifyPropertyChanged("Podcast");
            }
        }       
    }
}
