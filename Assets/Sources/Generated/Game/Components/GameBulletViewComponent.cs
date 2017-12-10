//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public BulletViewComponent bulletView { get { return (BulletViewComponent)GetComponent(GameComponentsLookup.BulletView); } }
    public bool hasBulletView { get { return HasComponent(GameComponentsLookup.BulletView); } }

    public void AddBulletView(BulletView newValue) {
        var index = GameComponentsLookup.BulletView;
        var component = CreateComponent<BulletViewComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBulletView(BulletView newValue) {
        var index = GameComponentsLookup.BulletView;
        var component = CreateComponent<BulletViewComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBulletView() {
        RemoveComponent(GameComponentsLookup.BulletView);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherBulletView;

    public static Entitas.IMatcher<GameEntity> BulletView {
        get {
            if (_matcherBulletView == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BulletView);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBulletView = matcher;
            }

            return _matcherBulletView;
        }
    }
}