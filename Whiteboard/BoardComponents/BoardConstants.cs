﻿/**
 * Owned By: Ashish Kumar Gupta
 * Created By: Ashish Kumar Gupta
 * Date Created: 11/12/2021
 * Date Modified: 11/12/2021
**/

namespace Whiteboard
{
    /// <summary>
    /// Class containing constants.
    /// </summary>
    public static class BoardConstants
    {
        /// <summary>
        /// undo-redo capacity
        /// </summary>
        public const int UNDO_REDO_STACK_SIZE = 7;

        /// <summary>
        /// Min possible size for data structure to be considered empty
        /// </summary>
        public const int EMPTY_SIZE = 0;

        /// <summary>
        /// The no. of update (CREATE, MODIFY, DELETE) a BoardServerShape can contain.
        /// </summary>
        public const int SINGLE_UPDATE_SIZE = 1;

        /// <summary>
        /// The higher user level. User who has full control.
        /// </summary>
        public const int HIGH_USER_LEVEL = 1;

        /// <summary>
        /// The lower user level. User who has partial control.
        /// </summary>
        public const int LOW_USER_LEVEL = 0;

        /// <summary>
        /// The initial state when whiteboard is clear.
        /// </summary>
        public const int INITIAL_CHECKPOINT_STATE = 0;
    }
}
