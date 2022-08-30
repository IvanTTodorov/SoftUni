namespace _01.BinaryTree
{
    using System;
    using System.Collections.Generic;

    public interface IAbstractBinaryTree<T>
    {
        T Value { get; }
        IAbstractBinaryTree<T> LeftChild { get; }
        IAbstractBinaryTree<T> RightChild { get; }

        string AsIndentedPreOrder(int indent);
        List<IAbstractBinaryTree<T>> PreOrder();
        List<IAbstractBinaryTree<T>> InOrder();
        List<IAbstractBinaryTree<T>> PostOrder();
        void ForEachInOrder(Action<T> action);
    }
}
