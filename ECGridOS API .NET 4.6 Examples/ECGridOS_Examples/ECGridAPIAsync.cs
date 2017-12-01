/*
 * ECGridAPIAsync
 * Copyright: Loren Data Corp.
 * Last Updated: 11/30/2017
 * Author: Greg Kolinski
 * Description: ECGridOS internal Class for EAP to TAP pattern convertion 
 * This class is indended to provide you the same functionality using the async/await calls as you get using the EAP pattern.
 * Methods from this class are called by the ECGridAPI Class.
 * 
 * This is a starter template
 * Please make note it uses the Web Reference for ECGridOS
 *  net.ecgridos
 * 
 *  Provided as Example only
 */

using System;
using ECGridOS_API = ECGridOS_Examples.net.ecgridos;
using System.ComponentModel;
using System.Threading.Tasks;

namespace ECGridOS_Examples
{
    /// <summary>
    /// Internal Static Class to support the calling of Asynchronous API Calls using the EAP to TAP Pattern
    /// </summary>
    internal static class ECGridAPIAsync
    {
        #region Class Properties

        /// <summary>
        /// Public Variable for Getting/Setting APIKey/SessionID
        /// </summary>
        public static string APIKey { get; set; }

        #endregion  

        #region EAP-to-TAP so you can use async/await

        /// <summary>
        /// Create the instance of the TaskCompletion Source
        /// </summary>
        /// <typeparam name="T">Type of source to create</typeparam>
        /// <param name="state">State of the Call</param>
        /// <returns></returns>
        private static TaskCompletionSource<T> CreateSource<T>(object state)
        {
            return new TaskCompletionSource<T>(state, TaskCreationOptions.None);
        }

        /// <summary>
        /// Used when the EAP event signinals its completion of an asynchronous operation.
        /// </summary>
        /// <typeparam name="T">Type of completed transfer</typeparam>
        /// <param name="tcs">Task completion source</param>
        /// <param name="e">Async arguments</param>
        /// <param name="getResult">function to get the async result</param>
        /// <param name="unregisterHandler">action to perform when complete</param>
        private static void TransferCompletion<T>(TaskCompletionSource<T> tcs, AsyncCompletedEventArgs e, Func<T> getResult, Action unregisterHandler)
        {
            if (e.UserState == tcs)
            {
                if (e.Cancelled)
                {
                    tcs.TrySetCanceled();
                }
                else if (e.Error != null)
                {
                    tcs.TrySetException(e.Error);
                }
                else
                {
                    tcs.TrySetResult(getResult());
                }

                unregisterHandler?.Invoke();
            }
        }

        #endregion

        #region Async/Await Methods for EAP Pattern ECGridOS API Calls

        /// <summary>
        /// Asyncronous Call to get the ECGridOS Version
        /// Converts EAP pattern into TAP pattern to use async/await
        /// </summary>
        /// <param name="client">The ECGridOS Client calling this method</param>
        /// <returns>Task VersionCompletedArgs</returns>
        public static Task<ECGridOS_API.VersionCompletedEventArgs> VersionAsync(this ECGridOS_API.ECGridOSAPIv3 client)
        {
            // Create the Task Completion source and handler
            var tcs = CreateSource<ECGridOS_API.VersionCompletedEventArgs>(null);
            ECGridOS_API.VersionCompletedEventHandler handler = null;
            handler = (sender, e) => TransferCompletion(tcs, e, () => e, () => client.VersionCompleted -= handler);
            client.VersionCompleted += handler;

            try
            {
                // make the async call
                client.VersionAsync(tcs);
            }
            catch
            {
                client.VersionCompleted -= handler;
                tcs.TrySetCanceled();
                throw;
            }

            return tcs.Task;
        } // END METHOD

        /// <summary>
        /// Asyncronous Call to get the ECGridOS DateTime in UTC
        /// Converts EAP pattern into TAP pattern to use async/await
        /// </summary>
        /// <param name="client">The ECGridOS Client calling this method</param>
        /// <returns>Task NowUTCCompletedEventArgs</returns>
        public static Task<ECGridOS_API.NowUTCCompletedEventArgs> NowUTCAsync(this ECGridOS_API.ECGridOSAPIv3 client)
        {
            // Create the Task Completion source and handler
            var tcs = CreateSource<ECGridOS_API.NowUTCCompletedEventArgs>(null);
            ECGridOS_API.NowUTCCompletedEventHandler handler = null;
            handler = (sender, e) => TransferCompletion(tcs, e, () => e, () => client.NowUTCCompleted -= handler);
            client.NowUTCCompleted += handler;

            try
            {
                // make the async call
                client.NowUTCAsync(tcs);
            }
            catch
            {
                client.NowUTCCompleted -= handler;
                tcs.TrySetCanceled();
                throw;
            }

            return tcs.Task;
        } // END METHOD

        /// <summary>
        /// Asyncronous Call to get the ECGridOS SessionInfo
        /// Converts EAP pattern into TAP pattern to use async/await
        /// Uses public propertiy for APIKey - must be set prior to calling
        /// </summary>
        /// <param name="client">The ECGridOS Client calling this method</param>
        /// <returns>Task WhoAmICompletedEventArgs</returns>
        public static Task<ECGridOS_API.WhoAmICompletedEventArgs> SessionInfoAsync(this ECGridOS_API.ECGridOSAPIv3 client)
        {
            // Create the Task Completion source and handler
            var tcs = CreateSource<ECGridOS_API.WhoAmICompletedEventArgs>(null);
            ECGridOS_API.WhoAmICompletedEventHandler handler = null;
            handler = (sender, e) => TransferCompletion(tcs, e, () => e, () => client.WhoAmICompleted -= handler);
            client.WhoAmICompleted += handler;

            try
            {
                // make the async call
                client.WhoAmIAsync(APIKey, tcs);
            }
            catch
            {
                client.WhoAmICompleted -= handler;
                tcs.TrySetCanceled();
                throw;
            }

            return tcs.Task;
        } // END METHOD

        /// <summary>
        /// Asyncronous Call to get the ECGridOS SessionInfo
        /// Converts EAP pattern into TAP pattern to use async/await
        /// </summary>
        /// <param name="client">The ECGridOS Client calling this method</param>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        /// <returns>Task WhoAmICompletedEventArgs</returns>
        public static Task<ECGridOS_API.WhoAmICompletedEventArgs> SessionInfoAsync(this ECGridOS_API.ECGridOSAPIv3 client, string APIKey)
        {
            // Create the Task Completion source and handler
            var tcs = CreateSource<ECGridOS_API.WhoAmICompletedEventArgs>(null);
            ECGridOS_API.WhoAmICompletedEventHandler handler = null;
            handler = (sender, e) => TransferCompletion(tcs, e, () => e, () => client.WhoAmICompleted -= handler);
            client.WhoAmICompleted += handler;

            try
            {
                // make the async call
                client.WhoAmIAsync(APIKey, tcs);
            }
            catch
            {
                client.WhoAmICompleted -= handler;
                tcs.TrySetCanceled();
                throw;
            }

            return tcs.Task;
        } // END METHOD

        #endregion

    } // END CLASS

} // END NAMESPACe
