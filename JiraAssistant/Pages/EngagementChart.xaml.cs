﻿using JiraAssistant.Controls;
using JiraAssistant.ViewModel;

namespace JiraAssistant.Pages
{
   public partial class EngagementChart
   {
      public EngagementChart(EngagementChartViewModel viewModel)
      {
         InitializeComponent();

         StatusBarControl = new EngagementChartStatusBar { DataContext = viewModel };

         DataContext = viewModel;
      }

      public override string Title { get { return "Engagement chart"; } }
   }
}
