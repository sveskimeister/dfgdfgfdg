using TARpe22MauiPlanets.Models;
using TARpe22MauiPlanets.Services;

namespace TARpe22MauiPlanets.Views;

public partial class PlanetsPage : ContentPage
{
	private const int AnimationDuration = 800;

	public PlanetsPage()
	{
		InitializeComponent();

		lstSaltyFood.ItemsSource = PlanetsService.GetSaltyFood();
		lstDesserts.ItemsSource = PlanetsService.GetDesserts();
	}

	async void GridArea_Tapped(System.Object sender, System.EventArgs e)
	{

	}

    async void Planets_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		await Navigation.PushAsync(new PlanetDetailsPage(e.CurrentSelection.First() as Planet));
	}
}