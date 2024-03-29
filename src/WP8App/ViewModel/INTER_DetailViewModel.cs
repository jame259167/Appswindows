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
    /// Implementation of INTER_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class INTER_DetailViewModel : ViewModelsBase.VMBase, IViewModels.IINTER_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.INTER_INTER _iNTER_INTER;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="INTER_DetailViewModel" /> class.
        /// </summary>
        /// <param name="iNTER_INTER">The Inter_inter.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public INTER_DetailViewModel(Repositories.INTER_INTER iNTER_INTER, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_iNTER_INTER = iNTER_INTER;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private Entities.INTERSchema _currentINTERSchema;

        /// <summary>
        /// CurrentINTERSchema property.
        /// </summary>		
        public Entities.INTERSchema CurrentINTERSchema
        {
            get
            {
				return _currentINTERSchema;
            }
            set
            {
                SetProperty(ref _currentINTERSchema, value);
            }
        }
	
		private bool _hasNextpanoramaINTER_Detail0;

        /// <summary>
        /// HasNextpanoramaINTER_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramaINTER_Detail0
        {
            get
            {
				return _hasNextpanoramaINTER_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaINTER_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramaINTER_Detail0;

        /// <summary>
        /// HasPreviouspanoramaINTER_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramaINTER_Detail0
        {
            get
            {
				return _hasPreviouspanoramaINTER_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaINTER_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechINTER_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechINTER_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentINTERSchema.Subtitle + " " + CurrentINTERSchema.Description);
        }
		

        private ICommand _textToSpeechINTER_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechINTER_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechINTER_DetailStaticControlCommand
        {
            get { return _textToSpeechINTER_DetailStaticControlCommand = _textToSpeechINTER_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechINTER_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareINTER_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareINTER_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentINTERSchema.Subtitle, CurrentINTERSchema.Description, "", CurrentINTERSchema.Image);
        }
		

        private ICommand _shareINTER_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareINTER_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareINTER_DetailStaticControlCommand
        {
            get { return _shareINTER_DetailStaticControlCommand = _shareINTER_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareINTER_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartINTER_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartINTER_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IINTER_DetailViewModel), CreateTileInfoINTER_DetailStaticControl());
        }
		

        private ICommand _pinToStartINTER_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartINTER_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartINTER_DetailStaticControlCommand
        {
            get { return _pinToStartINTER_DetailStaticControlCommand = _pinToStartINTER_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartINTER_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaINTER_Detail0 command.
        /// </summary>
        public  void NextpanoramaINTER_Detail0Delegate() 
        {
			var next =  _iNTER_INTER.Next(CurrentINTERSchema);

			if(next != null)
				CurrentINTERSchema = next;

			RefreshHasPrevNext();
        }
		

        private ICommand _nextpanoramaINTER_Detail0;

        /// <summary>
        /// Gets the NextpanoramaINTER_Detail0 command.
        /// </summary>
        public ICommand NextpanoramaINTER_Detail0
        {
            get { return _nextpanoramaINTER_Detail0 = _nextpanoramaINTER_Detail0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaINTER_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaINTER_Detail0 command.
        /// </summary>
        public  void PreviouspanoramaINTER_Detail0Delegate() 
        {
			var prev =  _iNTER_INTER.Previous(CurrentINTERSchema);

			if(prev != null)
				CurrentINTERSchema = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaINTER_Detail0;

        /// <summary>
        /// Gets the PreviouspanoramaINTER_Detail0 command.
        /// </summary>
        public ICommand PreviouspanoramaINTER_Detail0
        {
            get { return _previouspanoramaINTER_Detail0 = _previouspanoramaINTER_Detail0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaINTER_Detail0Delegate); }
        }

        private void RefreshHasPrevNext()
        {
            HasPreviouspanoramaINTER_Detail0 = _iNTER_INTER.HasPrevious(CurrentINTERSchema);
			HasNextpanoramaINTER_Detail0 = _iNTER_INTER.HasNext(CurrentINTERSchema);
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is Entities.INTERSchema)) { return; }
                
                CurrentINTERSchema = value as Entities.INTERSchema;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the INTER_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoINTER_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentINTERSchema.Id.ToString(),
                Title = CurrentINTERSchema.Subtitle,
                BackTitle = CurrentINTERSchema.Subtitle,
                BackContent = CurrentINTERSchema.Description,
                Count = 0,
                BackgroundImagePath = CurrentINTERSchema.Image,
                BackBackgroundImagePath = CurrentINTERSchema.Image,
                LogoPath = "Item-88d6e0cf-33a5-48ca-8c1f-d46142964cd8.png"
            };
            return tileInfo;
        }
    }
}
