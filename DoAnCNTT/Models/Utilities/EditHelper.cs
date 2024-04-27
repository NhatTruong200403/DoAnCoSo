namespace DoAnCNTT.Models.Utilities
{
    public static class EditHelper<T>
    {
        public static bool HasChanges(T newEntity, T existingEntity)
        {
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>))
                {
                    continue; // Bỏ qua việc kiểm tra các thuộc tính kiểu ICollection
                }
                var newValue = property.GetValue(newEntity);
                var existingValue = property.GetValue(existingEntity);
                if (!object.Equals(newValue, existingValue))
                {
                    return true;
                }
            }
            return false;
        }   
        
        public static void SetModifiedIfNecessary(T entity, bool hasChanges, string userId)
        {
            var modifiedByIdProperty = typeof(T).GetProperty("ModifiedById");
            if (modifiedByIdProperty != null)
                modifiedByIdProperty.SetValue(entity, hasChanges ? userId : null);

            var modifiedOnProperty = typeof(T).GetProperty("ModifiedOn");
            if (modifiedOnProperty != null)
                modifiedOnProperty.SetValue(entity, hasChanges ? DateTime.Now : null);
        }
    }
}
