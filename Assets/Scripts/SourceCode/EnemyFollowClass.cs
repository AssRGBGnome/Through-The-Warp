using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowClass : MonoBehaviour
{
    public class AI
    {
        private bool follow_mode = false;
        private float speed;
        private GameObject player, enemy;
        private Vector3 player_vector, enemy_vector;
        float prevX, currentX, movementX, diffX, averageX; //enemy
        float prevY, currentY, movementY, diffY, averageY; //player
        uint iterator, iterations = 45;
        bool ignore = false;
        float renable_distance = 2.0f;

        private int special_mode = 0;// this is some special stuff here

        public void init(GameObject player, GameObject enemy, float speed)
        {
            this.player = player;
            this.enemy = enemy;
            this.speed = speed;

            player_vector = player.transform.position;
            enemy_vector = enemy.transform.position;
        }

        public void init(GameObject player, GameObject enemy, float speed, int enable_special_mode)
        {
            this.player = player;
            this.enemy = enemy;
            this.speed = speed;

            player_vector = player.transform.position;
            enemy_vector = enemy.transform.position;
            special_mode = enable_special_mode;// this is where special mode is enabled by a specific number through decisions execution branch
        }

        public void enable()
        {
            follow_mode = true;
        }

        public void disable()
        {
            follow_mode = false;
        }

        public void move()
        {
            if (follow_mode)
            {
                player_vector = player.transform.position;
                enemy_vector = enemy.transform.position;

                if (!ignore)
                {
                    prevX = currentX; //new
                    prevY = currentY;
                    currentX = enemy_vector.x; //new
                    currentY = player_vector.y;
                    diffX = currentX - prevX;
                    diffY = currentY - prevY;
                    if (diffX < 0f) diffX = 0f - diffX; //inverts sign
                    movementX += diffX; //integrate only positive numbers

                    if (diffY < 0f) diffY = 0f - diffY; //inverts sign
                    movementY += diffY; //integrate only positive numbers                  
                }

                if (player_vector.x < enemy_vector.x - speed) enemy_vector.Set(enemy_vector.x - speed, enemy_vector.y, 0);
                else if (player_vector.x > enemy_vector.x + speed) enemy_vector.Set(enemy_vector.x + speed, enemy_vector.y, 0);


                if (!(ignore))
                {
                    //if ignore is not on, then we will assign calculated new position for enemy to follow player
                    enemy.transform.position = enemy_vector;
                }
                else
                {
                    //if ignore is currently enabled this is called, its primary purpose is to renable movement AKA turn ignore back off again
                    float distance = player_vector.x - enemy_vector.x;
                    if (distance < 0f) distance = 0f - distance; //flip sign if its negagive so we're always dealing with negative numbers
                    if (distance < renable_distance) ignore = false;

                }

                iterator++;
                if (iterator == iterations)
                {
                    iterator = 0;
                    averageX = movementX / (float)iterations;
                    movementX = 0;

                    averageY = movementY / (float)iterations;
                    movementY = 0;

                    Debug.Log("Movement Average : " + averageX);
                    if ((averageX > 0.00f) && (averageX < (speed - 0.01)))
                    {
                        if (special_mode == 1) Debug.Log("Movement Average : " + averageX);// ?

                        if (averageY < 0.0035) //0.0025
                        {
                            ignore = true;
                            // Debug.Log("Movement Average : " + averageX);
                        }
                    }
                }
            }
        }

        public void change_speed(float speed)
        {
            this.speed = speed;
        }

        // SPECIAL DEBUG FUNCTIONS
    }
}