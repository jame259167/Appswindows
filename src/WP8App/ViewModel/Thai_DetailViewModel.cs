// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls=WPAppStudio.Controls;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Repositories=WPAppStudio.Repositories;
using Services=WPAppStudio.Services;
using ViewModelsBase=WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of Thai_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class Thai_DetailViewModel : ViewModelsBase.VMBase, IViewModels.IThai_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.Thai_Thai _thai_Thai;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Thai_DetailViewModel" /> class.
        /// </summary>
        /// <param name="thai_Thai">The Thai_ Thai.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public Thai_DetailViewModel(Repositories.Thai_Thai thai_Thai, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_thai_Thai = thai_Thai;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private Entities.ThaiSchema _currentThaiSchema;

        /// <summary>
        /// CurrentThaiSchema property.
        /// </summary>		
        public Entities.ThaiSchema CurrentThaiSchema
        {
            get
            {
				return _currentThaiSchema;
            }
            set
            {
                SetProperty(ref _currentThaiSchema, value);
            }
        }
	
		private bool _hasNextpanoramaThai_Detail0;

        /// <summary>
        /// HasNextpanoramaThai_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramaThai_Detail0
        {
            get
            {
				return _hasNextpanoramaThai_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaThai_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramaThai_Detail0;

        /// <summary>
        /// HasPreviouspanoramaThai_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramaThai_Detail0
        {
            get
            {
				return _hasPreviouspanoramaThai_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaThai_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechThai_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechThai_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentThaiSchema.Subtitle + " " + CurrentThaiSchema.Description);
        }
		

        private ICommand _textToSpeechThai_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechThai_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechThai_DetailStaticControlCommand
        {
            get { return _textToSpeechThai_DetailStaticControlCommand = _textToSpeechThai_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechThai_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareThai_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareThai_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentThaiSchema.Subtitle, CurrentThaiSchema.Description, "", CurrentThaiSchema.Image);
        }
		

        private ICommand _shareThai_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareThai_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareThai_DetailStaticControlCommand
        {
            get { return _shareThai_DetailStaticControlCommand = _shareThai_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareThai_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartThai_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartThai_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IThai_DetailViewModel), CreateTileInfoThai_DetailStaticControl());
        }
		

        private ICommand _pinToStartThai_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartThai_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartThai_DetailStaticControlCommand
        {
            get { return _pinToStartThai_DetailStaticControlCommand = _pinToStartThai_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartThai_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaThai_Detail0 command.
        /// </summary>
        public  void NextpanoramaThai_Detail0Delegate() 
        {
			var next =  _thai_Thai.Next(CurrentThaiSchema);

			if(next != null)
				CurrentThaiSchema = next;

			RefreshHasPrevNext();
        }
		

        private ICommand _nextpanoramaThai_Detail0;

        /// <summary>
        /// Gets the NextpanoramaThai_Detail0 command.
        /// </summary>
        public ICommand NextpanoramaThai_Detail0
        {
            get { return _nextpanoramaThai_Detail0 = _nextpanoramaThai_Detail0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaThai_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaThai_Detail0 command.
        /// </summary>
        public  void PreviouspanoramaThai_Detail0Delegate() 
        {
			var prev =  _thai_Thai.Previous(CurrentThaiSchema);

			if(prev != null)
				CurrentThaiSchema = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaThai_Detail0;

        /// <summary>
        /// Gets the PreviouspanoramaThai_Detail0 command.
        /// </summary>
        public ICommand PreviouspanoramaThai_Detail0
        {
            get { return _previouspanoramaThai_Detail0 = _previouspanoramaThai_Detail0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaThai_Detail0Delegate); }
        }

        private void RefreshHasPrevNext()
        {
            HasPreviouspanoramaThai_Detail0 = _thai_Thai.HasPrevious(CurrentThaiSchema);
			HasNextpanoramaThai_Detail0 = _thai_Thai.HasNext(CurrentThaiSchema);
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is Entities.ThaiSchema)) { return; }
                
                CurrentThaiSchema = value as Entities.ThaiSchema;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the Thai_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoThai_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentThaiSchema.Id.ToString(),
                Title = CurrentThaiSchema.Subtitle,
                BackTitle = CurrentThaiSchema.Subtitle,
                BackContent = CurrentThaiSchema.Description,
                Count = 0,
                BackgroundImagePath = CurrentThaiSchema.Image,
                BackBackgroundImagePath = CurrentThaiSchema.Image,
                LogoPath = "Item-88d6e0cf-33a5-48ca-8c1f-d46142964cd8.png"
            };
            return tileInfo;
        }
    }
}
