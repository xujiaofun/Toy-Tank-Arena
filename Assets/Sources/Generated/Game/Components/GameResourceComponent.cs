//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ResourceComponent resource { get { return (ResourceComponent)GetComponent(GameComponentsLookup.Resource); } }
    public bool hasResource { get { return HasComponent(GameComponentsLookup.Resource); } }

    public void AddResource(string newValue) {
        var index = GameComponentsLookup.Resource;
        var component = CreateComponent<ResourceComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceResource(string newValue) {
        var index = GameComponentsLookup.Resource;
        var component = CreateComponent<ResourceComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveResource() {
        RemoveComponent(GameComponentsLookup.Resource);
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

    static Entitas.IMatcher<GameEntity> _matcherResource;

    public static Entitas.IMatcher<GameEntity> Resource {
        get {
            if (_matcherResource == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Resource);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherResource = matcher;
            }

            return _matcherResource;
        }
    }
}