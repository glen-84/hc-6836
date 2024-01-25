namespace Server.Types;

public record Book([property: GraphQLDeprecated("...")] string Title, Author Author);
