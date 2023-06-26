namespace ExtensionMethodsCollection
{
    public static class ObjectExtensions
    {
        /// <summary>
		/// Method for cloning EF's instantiated entities  
		/// </summary>
		/// <remarks>
		/// This method is an option for the ICloneable MemberwiseClone method when working with EF's instantiated entities so you can deal with proxy related exceptions.
		/// </remarks>
		/// <typeparam name="TEntity">Any kind of class</typeparam>
		/// <param name="obj">Object to be cloned</param>
		/// <returns>A new object with the same properties as the original</returns>
		public static TEntity Clone<TEntity>(this TEntity obj) where TEntity : class, new()
        {
            var sourceProperties = typeof(TEntity)
                                    .GetProperties()
                                    .Where(p => p.CanRead && p.CanWrite &&
                                            p.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute), true).Length == 0);

            var newObj = new TEntity();

            foreach (var property in sourceProperties)
            {
                property.SetValue(newObj, property.GetValue(obj, null), null);

            }

            return newObj;
        }
    }
}