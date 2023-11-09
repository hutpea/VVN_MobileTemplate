using System.Collections.Generic;
using Game.ScreenLoader.Home;
using VContainer;
using VContainer.Unity;

using VVN.Core.ScreenLoader;

using Game.ScreenLoader.Loading;
using UnityEngine;

public class GameLifetimeScope : LifetimeScope
{
    //public List<VVNPresenter> gamePresenters;
    //public List<VVNService> gameServices;
    public ScreenContainer screenContainer;
    public LoadingSceneView loadingSceneView;
    public VVNView vvnView;
    protected override void Configure(IContainerBuilder builder)
    {
        builder.UseEntryPoints(Lifetime.Singleton, pointsBuilder =>
        {
            pointsBuilder.Add<LoadingScenePresenter>();
            pointsBuilder.Add<HomeScenePresenter>();
        });
        builder.Register<LoadingSceneService>(Lifetime.Singleton);
        /*builder.RegisterComponent(loadingSceneView);
        builder.RegisterComponent(vvnView);*/
        foreach (var view in screenContainer.gameViews)
        {
            builder.RegisterComponent(view);
        }
        
        VVNLog.Print("GameLifetimeScope finishes configure!", Color.white);
    }
}
