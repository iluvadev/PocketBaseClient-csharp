// Project site: https://github.com/iluvadev/PocketBaseClient-csharp
//
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// Copyright (c) 2022, iluvadev, and released under MIT License.
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

using System.Collections;

namespace PocketBaseClient.Orm.Structures
{
    /// <summary>
    /// Represents a List of Items for PocketBase registries
    /// </summary>
    public interface IBasicList : IEnumerable
    {
        /// <summary>
        /// Name of the list
        /// </summary>
        string? Name { get; }

        /// <summary>
        /// Id of the list
        /// </summary>
        string? Id { get; }

        /// <summary>
        /// Says if the element is contained in the list
        /// </summary>
        /// <param name="element">The element to check if is contained</param>
        /// <returns></returns>
        bool Contains(object? element);

        /// <summary>
        /// Adds an element to the list
        /// </summary>
        /// <param name="element">The element to add</param>
        /// <returns></returns>
        object? Add(object? element);

        /// <summary>
        /// Adds all elements to the list
        /// </summary>
        /// <param name="elements">The elements to be added</param>
        void AddRange(IEnumerable<object?> elements)
        {
            foreach(var element in elements)
                Add(element);
        }

        /// <summary>
        /// Removes the element from the list
        /// </summary>
        /// <param name="element">The element to be removed</param>
        /// <returns></returns>
        object? Remove(object? element);

        /// <summary>
        /// Removes all elements from the list
        /// </summary>
        /// <param name="elements">The elements to be removed</param>
        void RemoveRange(IEnumerable<object?> elements)
        {
            foreach (var element in elements)
                Remove(element);
        }

        /// <summary>
        /// Removes all elements in the list
        /// </summary>
        /// <returns></returns>
        bool RemoveAll()
        {
            bool result = true;
            foreach (var item in this)
                result &= Remove(item) != null;

            return result;
        }

        /// <summary>
        /// Save Changes in the list
        /// </summary>
        /// <param name="mode">Says what to save</param>
        /// <returns></returns>
        bool SaveChanges(ListSaveDiscardModes mode);

        /// <summary>
        /// Discard changes in list
        /// </summary>
        /// <param name="mode">Says what to discard</param>
        void DiscardChanges(ListSaveDiscardModes mode);

        /// <summary>
        /// Updates the List with the list by parameter
        /// </summary>
        /// <param name="listWithUpdates"></param>
        void UpdateWith(IBasicList listWithUpdates)
        {
            RemoveAll();
            foreach (var element in listWithUpdates)
                Add(element);
        }

    }
}
